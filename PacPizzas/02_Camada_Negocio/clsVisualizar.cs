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

namespace Visualizar
{
    class clsVisualizar
    {
        #region Instância das Classes
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion

        #region Métodos da Classe clsVisualizar

        #region Métodos da Classe clsVisualizar - FUNÇÕES
        //***************
        //*** Funções ***
        //***************
        public DataTable CarregarGrid(string txtNumero_Pedido)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca nas Tabelas de Itens e Produtos ***
            Comando_SQL = "SELECT ";
            Comando_SQL = Comando_SQL + "item_pedido_codigo, ";
            Comando_SQL = Comando_SQL + "pedido_cliente_sequencial, ";
            Comando_SQL = Comando_SQL + "item_produto_codigo, ";
            Comando_SQL = Comando_SQL + "produto_nome, ";
            Comando_SQL = Comando_SQL + "produto_descricao, ";
            Comando_SQL = Comando_SQL + "produto_tamanho, ";
            Comando_SQL = Comando_SQL + "item_quantidade, ";
            Comando_SQL = Comando_SQL + "cliente_nome, ";
            Comando_SQL = Comando_SQL + "cliente_logradouro, ";
            Comando_SQL = Comando_SQL + "cliente_numero_residencia, ";
            Comando_SQL = Comando_SQL + "cliente_complemento, ";
            Comando_SQL = Comando_SQL + "cliente_bairro, ";
            Comando_SQL = Comando_SQL + "cliente_ponto_referencia ";
            Comando_SQL = Comando_SQL + "FROM itens,produtos,clientes,pedidos ";
            Comando_SQL = Comando_SQL + "WHERE ";
            Comando_SQL = Comando_SQL + "cliente_sequencial = pedido_cliente_sequencial AND ";
            Comando_SQL = Comando_SQL + "pedido_codigo = item_pedido_codigo AND ";
            Comando_SQL = Comando_SQL + "produto_codigo = item_produto_codigo AND ";

            //*** Se for  Selecionado alguma Busca, o Comando sofrefá um acrescento de outros Comandos SQL ***
            //*** O Método TRIM (Função Trim) Remove os espaços em Branco do Início e do Final, Ele não
            //*** remove os espaços da parte central ***
            if (txtNumero_Pedido.Trim() != "     ")
            {
                Comando_SQL = Comando_SQL + "item_pedido_codigo = '" + txtNumero_Pedido.Trim() + "'AND pedido_cliente_sequencial <> 0 ";
            }

            Comando_SQL = Comando_SQL + "ORDER BY item_pedido_codigo ASC ";

            //        //*** Prepara o Data Grid ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            return ds.Tables[0];
        }

        #endregion

        #region Métodos da Classe clsVisualizar - ROTINAS
        //***************
        //*** Rotinas ***
        //***************

        public void LimpaCampos(frmVisualizar _frmVisualizar)
        {
            //*** Limpa os Campos para a Próxima Inserção ***
            _frmVisualizar.txtNomeTEXT = "";
            _frmVisualizar.txtCliente_LogradouroTEXT = "";
            _frmVisualizar.txtCliente_Numero_ResidenciaTEXT = "";
            _frmVisualizar.txtCliente_ComplementoTEXT = "";
            _frmVisualizar.txtCliente_BairroTEXT = "";
            _frmVisualizar.txtCliente_Ponto_ReferenciaTEXT = "";


            //*** Trava os Campos do Formulário ***
            _frmVisualizar.txtNomeENABLE = false;
            _frmVisualizar.txtCliente_LogradouroENABLE = false;

            //*** Envia o Foco para  o Campo de Busca ***
            _frmVisualizar.txtNumero_PedidoFOCUS();
        }

        public void FormataGrid(frmVisualizar _frmVisualizar)
        {
            //*** Formata o Caption da Coluna no Data Grid ***
            _frmVisualizar.dgvRegistros_item_pedido_codigo_HEADERTEXT = "Número do Pedido";
            _frmVisualizar.dgvRegistros_pedido_cliente_sequencial_HEADERTEXT = "Código do Cliente";
            _frmVisualizar.dgvRegistros_item_produto_codigo_HEADERTEXT = "Código do Produto";
            _frmVisualizar.dgvRegistros_produto_nome_HEADERTEXT = "Nome do Produto";
            _frmVisualizar.dgvRegistros_produto_descricao_HEADERTEXT = "Descrição do Produto";
            _frmVisualizar.dgvRegistros_produto_tamanho_HEADERTEXT = "Tamanho do Produto";
            _frmVisualizar.dgvRegistros_item_quantidade_HEADERTEXT = "Quantidade";
            _frmVisualizar.dgvRegistros_cliente_nome_HEADERTEXT = "Nome do Cliente";
            _frmVisualizar.dgvRegistros_cliente_logradouro_HEADERTEXT = "Logradouro";
            _frmVisualizar.dgvRegistros_cliente_numero_residencia_HEADERTEXT = "Nro Residêmcia";
            _frmVisualizar.dgvRegistros_cliente_complemento_HEADERTEXT = "Logradouro";
            _frmVisualizar.dgvRegistros_cliente_bairro_HEADERTEXT = "Bairro";
            _frmVisualizar.dgvRegistros_cliente_ponto_referencia_HEADERTEXT = "Ponto de Referência";



            //*** Formata o Tamanho da Coluna no Data Grid ***
            _frmVisualizar.dgvRegistros_item_pedido_codigo_WIDTH = 100;
            _frmVisualizar.dgvRegistros_pedido_cliente_sequencial_WIDTH = 100;
            _frmVisualizar.dgvRegistros_item_produto_codigo_WIDTH = 100;
            _frmVisualizar.dgvRegistros_produto_nome_WIDTH = 200;
            _frmVisualizar.dgvRegistros_produto_descricao_WIDTH = 300;
            _frmVisualizar.dgvRegistros_produto_tamanho_WIDTH = 200;
            _frmVisualizar.dgvRegistros_item_quantidade_WIDTH = 100;
            _frmVisualizar.dgvRegistros_cliente_nome_WIDTH = 0;
            _frmVisualizar.dgvRegistros_cliente_logradouro_WIDTH = 0;
            _frmVisualizar.dgvRegistros_cliente_numero_residencia_WIDTH = 0;
            _frmVisualizar.dgvRegistros_cliente_complemento_WIDTH = 0;
            _frmVisualizar.dgvRegistros_cliente_bairro_WIDTH = 0;
            _frmVisualizar.dgvRegistros_cliente_ponto_referencia_WIDTH = 0;

            //*** Deixa o Item do Grid Invisível ***
            _frmVisualizar.dgv_pedido_cliente_sequencial_VISIBLE = false;
            _frmVisualizar.dgv_cliente_nome_VISIBLE = false;
            _frmVisualizar.dgv_cliente_logradouro_VISIBLE = false;
            _frmVisualizar.dgv_cliente_numero_residencia_VISIBLE = false;
            _frmVisualizar.dgv_cliente_complemento_VISIBLE = false;
            _frmVisualizar.dgv_cliente_bairro_VISIBLE = false;
            _frmVisualizar.dgv_cliente_ponto_referencia_VISIBLE = false;
        }

        public void CarregarCamposGrid(frmVisualizar _frmVisualizar)
        {
            //*** Carrega os Campos da Linha que foi Clicada ***
            _frmVisualizar.txtNomeTEXT = _frmVisualizar.dgvRegistros_cliente_nome_GRIDCLICK;
            _frmVisualizar.txtCliente_LogradouroTEXT = _frmVisualizar.dgvRegistros_cliente_logradouro_GRIDCLICK;
            _frmVisualizar.txtCliente_Numero_ResidenciaTEXT = _frmVisualizar.dgvRegistros_cliente_numero_residencia_GRIDCLICK;
            _frmVisualizar.txtCliente_ComplementoTEXT = _frmVisualizar.dgvRegistros_cliente_complemento_GRIDCLICK;
            _frmVisualizar.txtCliente_BairroTEXT = _frmVisualizar.dgvRegistros_cliente_bairro_GRIDCLICK;
            _frmVisualizar.txtCliente_Ponto_ReferenciaTEXT = _frmVisualizar.dgvRegistros_cliente_ponto_referencia_GRIDCLICK;


            //*** Desativa o Campo que receberá o ID ***
            _frmVisualizar.txtNomeENABLE = false;
            _frmVisualizar.txtCliente_LogradouroENABLE = false;
            _frmVisualizar.txtCliente_Numero_ResidenciaENABLE = false;
            _frmVisualizar.txtCliente_ComplementoENABLE = false;
            _frmVisualizar.txtCliente_BairroENABLE = false;
            _frmVisualizar.txtCliente_Ponto_ReferenciaENABLE = false;

        }
        #endregion

        #endregion
    }
}