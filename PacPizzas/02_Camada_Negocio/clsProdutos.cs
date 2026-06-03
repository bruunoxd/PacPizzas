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

namespace Produtos
{
    class clsProdutos
    {
        #region Instância das Classes
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion

        #region Métodos da Classe clsProdutos

        #region Métodos da Classe clsProdutos - FUNÇÕES
        //***************
        //*** Funções ***
        //***************
        public DataTable CarregarGrid(string BuscarPor, string ProcurarEm)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca na Tabela de Produtos ***
            Comando_SQL = "SELECT ";
            Comando_SQL = Comando_SQL + "produto_codigo, ";
            Comando_SQL = Comando_SQL + "produto_nome, ";
            Comando_SQL = Comando_SQL + "produto_tamanho, ";
            Comando_SQL = Comando_SQL + "LPAD(FORMAT(produto_valor_unitario,2),6,' ') AS produto_valor_unitario, ";// Formatar o valor Unitário para não deslocar para esquerda
            Comando_SQL = Comando_SQL + "produto_descricao ";
            Comando_SQL = Comando_SQL + "FROM produtos ";

            //*** Se for  Selecionado alguma Busca, o Comando sofrefá um acrescento de outros Comandos SQL ***
            //*** O Método TRIM (Função Trim) Remove os espaços em Branco do Início e do Final, Ele não
            //*** remove os espaços da parte central ***
            if (BuscarPor.Trim() != "")
            {
                if (ProcurarEm.Trim() != "")
                {
                    if (ProcurarEm.Trim() == "Produto Código")
                    {
                        Comando_SQL = Comando_SQL + "WHERE produto_codigo = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Nome do Produto")
                    {
                        Comando_SQL = Comando_SQL + "WHERE produto_nome = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Tamanho")
                    {
                        Comando_SQL = Comando_SQL + "WHERE produto_tamanho = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Valor Unitário")
                    {
                        Comando_SQL = Comando_SQL + "WHERE produto_valor_unitario = '" + BuscarPor.Trim() + "' ";
                    }
                    else
                    {
                        Comando_SQL = Comando_SQL + "WHERE produto_descricao = '" + (BuscarPor.Trim()) + "' ";
                    }
                }
            }

            Comando_SQL = Comando_SQL + "ORDER BY produto_codigo";

            //*** Prepara o Data Grid ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            return ds.Tables[0];
        }

        public bool ValidaDados(frmProdutos _frmProdutos)
        {
            bool Resultado;
            string Comando_SQL;

            Resultado = true;

            if (_frmProdutos.txtProduto_CodigoTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtProduto_Codigo ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Codigo do Produto!");
                _frmProdutos.txtProduto_CodigoFOCUS();
            }


            else if (_frmProdutos.txtProduto_NomeTEXT.Trim() == "")
            {
                //**************************************
                //*** Valida o Campo txtProduto_Nome ***
                //**************************************

                Resultado = false;
                MessageBox.Show("Por Favor, Informe o Nome do Produto!");
                _frmProdutos.txtProduto_NomeFOCUS();
            }

            else if (_frmProdutos.txtProduto_TamanhoTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtProduto_Tamanho ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Tamanho!");
                _frmProdutos.txtProduto_TamanhoFOCUS();
            }

            else if (_frmProdutos.txtProduto_Valor_UnitarioTEXT.Trim() == "R$   ,")
            {
                //***********************************************
                //*** Valida o Campo txtProduto_Valor_Unitario ***
                //***********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Valor Unitário!");
                _frmProdutos.txtProduto_Valor_UnitarioFOCUS();

            }

            else if (_frmProdutos.txtProduto_DescricaoTEXT.Trim() == "")
            {
                //***********************************************
                //*** Valida o Campo txtProduto_Descricao ***
                //***********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe a Descrição do Produto!");
                _frmProdutos.txtProduto_DescricaoFOCUS();

            }
            else
            {
                //********************************************** 
                //*** Verifica se o Código de Produto já existe na Tabela na Inclusão ***
                //**********************************************

                if (_frmProdutos.txtProduto_CodigoENABLE == true)
                {
                    Comando_SQL = "SELECT ";
                    Comando_SQL = Comando_SQL + "produto_codigo ";
                    Comando_SQL = Comando_SQL + "FROM ";
                    Comando_SQL = Comando_SQL + "produtos ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "produto_codigo = '" +
                        clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_CodigoTEXT.Trim()) + "' ";

                    if (objConexaoBanco.Retorna_ID(Comando_SQL, "produto_codigo").Trim() != "")
                    {
                        Resultado = false;
                        MessageBox.Show("Este Código de Produto já existe, por favor, informe outro!");
                        _frmProdutos.txtProduto_NomeFOCUS();
                    }
                }


            }
            return Resultado;
        }
        #endregion

        #region Métodos da Classe clsProdutos - ROTINAS
        //***************
        //*** Rotinas ***
        //***************

        public void LimpaCampos(frmProdutos _frmProdutos)
        {
            //*** Limpa os Campos para a Próxima Inserção ***
            _frmProdutos.txtProduto_CodigoTEXT = "";
            _frmProdutos.txtProduto_NomeTEXT = "";
            _frmProdutos.txtProduto_TamanhoTEXT = "";
            _frmProdutos.txtProduto_Valor_UnitarioTEXT = "";
            _frmProdutos.txtProduto_DescricaoTEXT = "";

            //*** Trava os Campos do Formulário ***
            _frmProdutos.txtProduto_CodigoENABLE = false;
            _frmProdutos.txtProduto_NomeENABLE = false;
            _frmProdutos.txtProduto_TamanhoENABLE = false;
            _frmProdutos.txtProduto_Valor_UnitarioENABLE = false;
            _frmProdutos.txtProduto_DescricaoENABLE = false;

            //*** Envia o Foco para  o Campo de Busca ***
            _frmProdutos.txtBuscarPorFOCUS();
        }

        public void FormataGrid(frmProdutos _frmProdutos)
        {
            //*** Formata o Caption da Coluna no Data Grid ***
            _frmProdutos.dgvRegistros_produto_codigo_HEADERTEXT = "Produto Código";
            _frmProdutos.dgvRegistros_produto_nome_HEADERTEXT = "Nome do Produto";
            _frmProdutos.dgvRegistros_produto_tamanho_HEADERTEXT = "Tamanho";
            _frmProdutos.dgvRegistros_produto_valor_unitario_HEADERTEXT = "Valor Unitário";
            _frmProdutos.dgvRegistros_produto_descricao_HEADERTEXT = "Descrição";

            //*** Formata o Tamanho da Coluna no Data Grid ***
            _frmProdutos.dgvRegistros_produto_codigo_WIDTH = 150;
            _frmProdutos.dgvRegistros_produto_nome_WIDTH = 200;
            _frmProdutos.dgvRegistros_produto_tamanho_WIDTH = 200;
            _frmProdutos.dgvRegistros_produto_valor_unitario_WIDTH = 200;
            _frmProdutos.dgvRegistros_produto_descricao_WIDTH = 300;
        }

        public void EfetuaGravacao(frmProdutos _frmProdutos)
        {
            string Comando_SQL;

            //*** Efetua a Validação de Dados para a Gravação na Tabela de 
            //*** Clientes ***
            if (ValidaDados(_frmProdutos) == true)
            {
                //*** Verifica se o Processo de Gravação será de Inclusão ou Alteração
                if (_frmProdutos.txtProduto_CodigoENABLE == true)
                {
                    //****************************
                    //*** Processo de Inclusão ***
                    //****************************

                    //*** Prepara Comando de Inclusão ***
                    Comando_SQL = " INSERT INTO Produtos(";
                    Comando_SQL = Comando_SQL + "produto_codigo, ";
                    Comando_SQL = Comando_SQL + "produto_nome, ";
                    Comando_SQL = Comando_SQL + "produto_tamanho, ";
                    Comando_SQL = Comando_SQL + "produto_valor_unitario, ";
                    Comando_SQL = Comando_SQL + "produto_descricao) ";
                    Comando_SQL = Comando_SQL + "VALUES (";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_CodigoTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_NomeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_TamanhoTEXT.Trim()) + "', ";
                    //Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_Valor_UnitarioTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaVirgulaPonto(clsRotinasGerais.RemoveCaracteres(clsRotinasGerais.RemoveCaracteres(_frmProdutos.txtProduto_Valor_UnitarioTEXT.Trim(), "R$"), ".")) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_DescricaoTEXT.Trim()) + "')";

                    //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Inclusão Efetuado ***
                    MessageBox.Show("Inclusão Efetuada!!!");
                    LimpaCampos(_frmProdutos);
                }
                else
                {
                    //*****************************
                    //*** Processo de Alteração ***
                    //*****************************

                    //*** Prepara o Comando de Inserção
                    Comando_SQL = "UPDATE Produtos SET ";
                    Comando_SQL = Comando_SQL + "produto_nome = '" + clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_NomeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "produto_tamanho = '" + clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_TamanhoTEXT.Trim()) + "', ";
                    //Comando_SQL = Comando_SQL + "produto_valor_unitario = '" + clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_Valor_UnitarioTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "produto_valor_unitario = '" + clsRotinasGerais.TrocaVirgulaPonto(clsRotinasGerais.RemoveCaracteres(clsRotinasGerais.RemoveCaracteres(_frmProdutos.txtProduto_Valor_UnitarioTEXT.Trim(), "R$"), ".")) + "', ";
                    Comando_SQL = Comando_SQL + "produto_descricao = '" + clsRotinasGerais.TrocaAspasSimples(_frmProdutos.txtProduto_DescricaoTEXT.Trim()) + "' ";
                    Comando_SQL = Comando_SQL + "WHERE produto_codigo = '" + _frmProdutos.txtProduto_CodigoTEXT.Trim() + "' ";

                    //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Alteração Efetuado ***
                    MessageBox.Show("Alteração Efetuada!!!");
                    LimpaCampos(_frmProdutos);
                }
                //*** Após a Alteração, realiza a Busca na Tabela de Produtos e 
                //*** Mostra o resultado no Grid ***
                _frmProdutos.dgvRegistrosDATASOURCE = CarregarGrid(_frmProdutos.txtBuscarPorTEXT.Trim(), _frmProdutos.cmbProcurarEmTEXT.Trim());
                FormataGrid(_frmProdutos);
            }

        }
        public void EfetuaExclusao(frmProdutos _frmProdutos)
        {
            string Comando_SQL;

            //*** Verifica se foi selecionado um registro para exclusão ***
            if (_frmProdutos.txtProduto_NomeTEXT.Trim() != "")
            {
                if (MessageBox.Show("Deseja Excluir o Registro com a Razão Social: " +
                    _frmProdutos.txtProduto_NomeTEXT.Trim() +
                    " ?", "Exclusão de Registro", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //*** Prepara o Comando de Exclusão ***
                    Comando_SQL = "DELETE FROM Produtos ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "produto_codigo = '" +
                    _frmProdutos.txtProduto_CodigoTEXT.Trim() + "'";

                    //*** Executa o Comando Preparado Acima utilizando o 
                    //*** Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Exclusão Efetuada ***
                    MessageBox.Show("Exclusão Efetuada!!!");

                    LimpaCampos(_frmProdutos);

                    //*** Após a Exclusão, realiza a Busca na Tabela de Produtos
                    //*** e Mostra o resultado no Grid ***
                    _frmProdutos.dgvRegistrosDATASOURCE = CarregarGrid(_frmProdutos.txtBuscarPorTEXT.Trim(), _frmProdutos.cmbProcurarEmTEXT.Trim());
                    FormataGrid(_frmProdutos);

                }
            }
            else
            {
                MessageBox.Show("Por Favor, Selecione um Registro!");
            }
        }

        public void CarregarCamposGrid(frmProdutos _frmProdutos)
        {
            //*** Carrega os Campos da Linha que foi Clicada ***
            _frmProdutos.txtProduto_CodigoTEXT = _frmProdutos.dgvRegistros_produto_codigo_GRIDCLICK;
            _frmProdutos.txtProduto_NomeTEXT = _frmProdutos.dgvRegistros_produto_nome_GRIDCLICK;
            _frmProdutos.txtProduto_TamanhoTEXT = _frmProdutos.dgvRegistros_produto_tamanho_GRIDCLICK;
            _frmProdutos.txtProduto_Valor_UnitarioTEXT = _frmProdutos.dgvRegistros_produto_valor_unitario_GRIDCLICK;
            _frmProdutos.txtProduto_DescricaoTEXT = _frmProdutos.dgvRegistros_produto_descricao_GRIDCLICK;

            //*** Desativa o Campo que receberá o ID ***
            _frmProdutos.txtProduto_CodigoENABLE = false;

            //*** Ativa o Campo de Senha ***
            _frmProdutos.txtProduto_NomeENABLE = true;
            _frmProdutos.txtProduto_TamanhoENABLE = true;
            _frmProdutos.txtProduto_Valor_UnitarioENABLE = true;
            _frmProdutos.txtProduto_DescricaoENABLE = true;
        }
        #endregion

        #endregion
    }
}