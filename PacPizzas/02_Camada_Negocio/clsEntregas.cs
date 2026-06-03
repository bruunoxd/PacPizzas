using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************************************
//*** Habilita as Referências (Namespace) a serem utilizadas ***
//**************************************************************
//*** A palavra-chave de namespace (Referência) é usada para
//*** declarar um escopo que contém um conjunto de objetos
//*** relacionados. Você pode usar um namespace para organizar
//*** elementos de código e para criar globalmente tipos 
//*** exclusivos.
using System.Windows.Forms; // Classe de Formulários
using System.Data; // Classe de Dados
using MySql.Data.MySqlClient; // Biblioteca para Acessar o MySQL
using RotinasGerais; // Este é o Módulo de Visão Global
using ConexaoBanco; // Esta é a Classe de Conexão com o Banco de Dados
using PacPizzas; // Esta é a Classe Geral do Projeto, onde estão os Formulários

namespace Entregas
{
    class clsEntregas
    {
        #region Instância das Classes
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion

        #region Métodos da Classe clsEntregas

        #region Métodos da Classe clsEntregas - FUNÇÕES
        //***************
        //*** Funções ***
        //***************
        public DataTable CarregarGrid(string DataPedido)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca na Tabela de Pedidos ***
            Comando_SQL = "SELECT ";
            Comando_SQL = Comando_SQL + "pedido_codigo, ";
            Comando_SQL = Comando_SQL + "DATE_FORMAT(pedido_data, '%d/%m/%Y') AS pedido_data, ";
            Comando_SQL = Comando_SQL + "pedido_horario, ";
            Comando_SQL = Comando_SQL + "pedido_horario_saida, ";
            Comando_SQL = Comando_SQL + "pedido_cliente_sequencial, ";
            Comando_SQL = Comando_SQL + "pedido_funcionario_cpf ";
            Comando_SQL = Comando_SQL + "FROM pedidos ";

            //*** Se for  Selecionado alguma Busca, o Comando sofrefá um acrescento de outros Comandos SQL ***
            //*** O Método TRIM (Função Trim) Remove os espaços em Branco do Início e do Final, Ele não
            //*** remove os espaços da parte central ***
            if (DataPedido.Trim() != "/  /")
            {
                Comando_SQL = Comando_SQL + "WHERE pedido_data = '" + clsRotinasGerais.Inverte_Data(DataPedido.Trim()) + "' AND pedido_cliente_sequencial <> 0 ";
            }
            else
            {
                Comando_SQL = Comando_SQL + "WHERE pedido_cliente_sequencial <> 0 ";
            }
            Comando_SQL = Comando_SQL + "ORDER BY pedido_codigo";

            //        //*** Prepara o Data Grid ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            return ds.Tables[0];
        }

        #endregion

        #region Métodos da Classe clsProdutos - ROTINAS
        //***************
        //*** Rotinas ***
        //***************

        public void LimpaCampos(frmEntregas _frmEntregas)
        {
            //*** Limpa os Campos para a Próxima Inserção ***
            _frmEntregas.txtPedido_CodigoTEXT = "";

            //*** Trava os Campos do Formulário ***
            _frmEntregas.txtPedido_CodigoENABLE = false;
            _frmEntregas.txtPedido_Horario_SaidaENABLE = false;

            //*** Envia o Foco para  o Campo de Busca ***
            _frmEntregas.txtDataPedidoFOCUS();
        }

        public void FormataGrid(frmEntregas _frmEntregas)
        {
            //*** Formata o Caption da Coluna no Data Grid ***
            _frmEntregas.dgvRegistros_pedido_codigo_HEADERTEXT = "Pedido Código";
            _frmEntregas.dgvRegistros_pedido_data_HEADERTEXT = "Data do Pedido";
            _frmEntregas.dgvRegistros_pedido_horario_HEADERTEXT = "Horário do Pedido";
            _frmEntregas.dgvRegistros_pedido_cliente_sequencial_HEADERTEXT = "Código do Cliente";
            _frmEntregas.dgvRegistros_pedido_funcionario_cpf_HEADERTEXT = "Identificação Funcionário";
            _frmEntregas.dgvRegistros_pedido_horario_saida_HEADERTEXT = "Pedido Horário Saida";

            //*** Formata o Tamanho da Coluna no Data Grid ***
            _frmEntregas.dgvRegistros_pedido_codigo_WIDTH = 100;
            _frmEntregas.dgvRegistros_pedido_data_WIDTH = 100;
            _frmEntregas.dgvRegistros_pedido_horario_WIDTH = 100;
            _frmEntregas.dgvRegistros_pedido_cliente_sequencial_WIDTH = 100;
            _frmEntregas.dgvRegistros_pedido_funcionario_cpf_WIDTH = 100;
            _frmEntregas.dgvRegistros_pedido_horario_saida_WIDTH = 100;
        }


            public bool ValidaDados(frmEntregas _frmEntregas)
        {
            bool Resultado;

            Resultado = true;

            if (_frmEntregas.txtPedido_CodigoTEXT.Trim() == "")
            {
                //***************************************
                //***   Valida o Campo txtPedido_Codigo    ***
                //***************************************

                Resultado = false;
                MessageBox.Show("Por Favor Selecionar Pedido!");
                _frmEntregas.txtPedido_CodigoFOCUS();
            }
            return Resultado;
        }


            public void EfetuaGravacao(frmEntregas _frmEntregas)
            {
                string Comando_SQL;

                //*** Efetua a Validação da Dados para a Gravação na Tabela
                //*** de Entregas ***
                if (ValidaDados(_frmEntregas) == true)
                {
                    //*** Verifica se o Processo de Gravação será de Inclusão ou Alteração
                    if (_frmEntregas.txtPedido_CodigoENABLE == false)
                    {
                        //*****************************
                        //*** Processo de Alteração ***
                        //*****************************

                        //*** Prepara o Comando de Inserção
                        Comando_SQL = "UPDATE Pedidos SET ";
                        Comando_SQL = Comando_SQL + "pedido_horario_saida = '" + _frmEntregas.txtPedido_Horario_SaidaTEXT.Trim() + "' ";
                        Comando_SQL = Comando_SQL + "WHERE pedido_codigo = '" + _frmEntregas.txtPedido_CodigoTEXT.Trim() + "' ";

                        //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
                        objConexaoBanco.Executar_Comando(Comando_SQL);

                        //*** Exibe a Mensagem de Alteração Efetuado ***
                        MessageBox.Show("Inserido Horário de Saída para Entrega!!!");
                        LimpaCampos(_frmEntregas);
                    }

                    //*** Após a Alteração, realiza a Busca na Tabela de Produtos e 
                    //*** Mostra o resultado no Grid ***
                    _frmEntregas.dgvRegistrosDATASOURCE = CarregarGrid(_frmEntregas.txtDataPedidoTEXT.Trim());
                    FormataGrid(_frmEntregas);

                }

            }  

        public void CarregarCamposGrid(frmEntregas _frmEntregas)
        {
            //*** Carrega os Campos da Linha que foi Clicada ***
            _frmEntregas.txtPedido_CodigoTEXT = _frmEntregas.dgvRegistros_pedido_codigo_GRIDCLICK;

            //*** Desativa o Campo que receberá o ID ***
            _frmEntregas.txtPedido_CodigoENABLE = false;
            _frmEntregas.txtPedido_Horario_SaidaENABLE = false;
        }
        #endregion

        #endregion
    }
}