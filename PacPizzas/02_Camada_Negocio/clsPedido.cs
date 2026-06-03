using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using ConexaoBanco;
using RotinasGerais;
using PacPizzas;

namespace Pedido
{
    class clsPedido
    {
        #region Instância das Classes
        //*** Instancia os Objetos da Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion

        #region CriarPedido
        public void CriarPedido(frmPedido _frmPedido)
        {
            string Comando_SQL;

            //*** Prepara o Comando para Inserção do Pedido ***
            Comando_SQL = "INSERT INTO pedidos(";
            Comando_SQL = Comando_SQL + "pedido_data, ";
            Comando_SQL = Comando_SQL + "pedido_horario, ";
            Comando_SQL = Comando_SQL + "pedido_funcionario_cpf) ";
            Comando_SQL = Comando_SQL + "VALUES(";
            Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.Inverte_Data(_frmPedido.txtDataTEXT) + "', ";
            Comando_SQL = Comando_SQL + "'" + _frmPedido.txtHorarioTEXT.Trim() + "', ";
            Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaVirgulaPonto(_frmPedido.txtCPFTEXT.Trim()) + "') ";

            //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
            objConexaoBanco.Executar_Comando(Comando_SQL);

            //*** Comando para Trazer o Número do Pedido ***
            Comando_SQL = "SELECT MAX(pedido_codigo) AS pedido_codigo FROM pedidos";

            _frmPedido.txtPedidoTEXT = objConexaoBanco.Retorna_ID(Comando_SQL, "pedido_codigo");
        }

        public void FinalizarPedido(frmPedido _frmPedido)
        {
            string Comando_SQL;

            //*** Prepara o Comando para Inserção do Pedido ***
            Comando_SQL = "UPDATE pedidos SET ";
            Comando_SQL = Comando_SQL + "pedido_total = '" + clsRotinasGerais.TrocaVirgulaPonto(_frmPedido.Pedido_TotalTEXT.Trim()) + "', ";
            Comando_SQL = Comando_SQL + "pedido_cliente_sequencial = '" + _frmPedido.txtcliente_codigoTEXT.Trim() + "' ";
            Comando_SQL = Comando_SQL + "WHERE ";
            Comando_SQL = Comando_SQL + "pedido_codigo = " + _frmPedido.txtPedidoTEXT.Trim() + " ";

            //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
            objConexaoBanco.Executar_Comando(Comando_SQL);
        }

        public bool ValidaDados(frmPedido _frmPedido)
        {
            bool Resultado;

            Resultado = true;

            if (_frmPedido.txtTelefoneTEXT.Trim() == "(  )     -")
            {
                //***************************************
                //***   Valida o Campo txtTelefone    ***
                //***************************************

                Resultado = false;
                MessageBox.Show("Por favor, Informe o Cliente!");
                _frmPedido.txtTelefoneFOCUS();
            }
            else if (_frmPedido.Pedido_TotalTEXT.Trim() == "")
            {
                //***************************************
                //***   Valida o Campo txtTelefone    ***
                //***************************************

                Resultado = false;
                MessageBox.Show("Não Há Itens Para Finalizar o Pedido!");
                _frmPedido.Pedido_TotalFOCUS();
            }
            return Resultado;
        }


        #endregion

        #region CarregaComboPizza
        public void CarregaComboPizza(frmPedido _frmPedido)
        {
            //*** Declara a Variável ***
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca na Tabela de Clientes ***
            Comando_SQL = "SELECT CONCAT(CONVERT(produto_codigo,CHAR),'-',produto_nome,' - TAMANHO: ',produto_tamanho,' - PREÇO R$ ',CONVERT(produto_valor_unitario,CHAR)) AS produto_codigo_nome FROM produtos WHERE produto_tamanho <> '-' ORDER BY produto_nome ASC";


            //*** Prepara o Data Adapter ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            _frmPedido.cbpedido_pizzaDATASOURCE = ds.Tables[0];
            _frmPedido.cbpedido_pizzaDISPLAYMEMBER = "produto_codigo_nome";
            _frmPedido.cbpedido_pizzaVALUEMEMBER = "produto_codigo_nome";

        }
        #endregion

        #region CarregaComboProduto
        public void CarregaComboProduto(frmPedido _frmPedido)
        {
            string Comando_SQL;

            Comando_SQL = "SELECT CONCAT(CONVERT(produto_codigo,CHAR),'-',produto_nome,' - R$ ',CONVERT(produto_valor_unitario,CHAR)) AS produto_codigo_nome FROM produtos WHERE produto_tamanho = '-' ORDER BY produto_codigo ASC";

            //*** Prepara o Data Adapter ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            _frmPedido.cbpedido_produtoDATASOURCE = ds.Tables[0];
            _frmPedido.cbpedido_produtoDISPLAYMEMBER = "produto_codigo_nome";
            _frmPedido.cbpedido_produtoVALUEMEMBER = "produto_codigo_nome";

        }
        #endregion

        #region ObtemCodigoPizza
        public string ObtemCodigoPizza(frmPedido _frmPedido)
        {
            string CodigoProduto;
            int PosicaoHifen;

            PosicaoHifen = _frmPedido.cbpedido_pizzaTEXT.IndexOf("-");

            CodigoProduto = _frmPedido.cbpedido_pizzaTEXT.Substring(0, PosicaoHifen);

            return CodigoProduto;
        }
        #endregion

        #region ObtemCodigoProduto
        public string ObtemCodigoProduto(frmPedido _frmPedido)
        {
            string CodigoProduto;
            int PosicaoHifen;

            PosicaoHifen = _frmPedido.cbpedido_produtoTEXT.IndexOf("-");

            CodigoProduto = _frmPedido.cbpedido_produtoTEXT.Substring(0, PosicaoHifen);

            return CodigoProduto;
        }
        #endregion

        #region InsereItemPizza
        public void InsereItemPizza(frmPedido _frmPedido)
        {
            string Comando_SQL, CodigoProduto, ValorProduto;
            double ValorPizza, QtdePizza;

            CodigoProduto = ObtemCodigoPizza(_frmPedido);
            Comando_SQL = "SELECT produto_valor_unitario FROM produtos WHERE produto_codigo = '" + CodigoProduto.Trim() + "'";
            ValorProduto = objConexaoBanco.Retorna_ID(Comando_SQL, "produto_valor_unitario");

            QtdePizza = Convert.ToDouble(_frmPedido.cbQuantidadeTEXT);
            ValorPizza = Convert.ToDouble(ValorProduto);

            ValorProduto = Convert.ToString(QtdePizza * ValorPizza);

            //*** Prepara o Comando para Inserção do Pedido ***
            Comando_SQL = "INSERT INTO itens(";
            Comando_SQL = Comando_SQL + "item_quantidade, ";
            Comando_SQL = Comando_SQL + "item_valor_total, ";
            Comando_SQL = Comando_SQL + "item_produto_codigo, ";
            Comando_SQL = Comando_SQL + "item_pedido_codigo) ";
            Comando_SQL = Comando_SQL + "VALUES(";
            Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaVirgulaPonto(_frmPedido.cbQuantidadeTEXT) + "', ";
            Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaVirgulaPonto(ValorProduto) + "', ";
            Comando_SQL = Comando_SQL + "'" + CodigoProduto.Trim() + "', ";
            Comando_SQL = Comando_SQL + "'" + _frmPedido.txtPedidoTEXT.Trim() + "') ";

            //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
            objConexaoBanco.Executar_Comando(Comando_SQL);
        }
        #endregion

        #region InsereItemProduto
        public void InsereItemProduto(frmPedido _frmPedido)
        {
            string Comando_SQL, CodigoProduto, ValorProduto;

            CodigoProduto = ObtemCodigoProduto(_frmPedido);
            Comando_SQL = "SELECT produto_valor_unitario FROM produtos WHERE produto_codigo = '" + CodigoProduto.Trim() + "'";
            ValorProduto = objConexaoBanco.Retorna_ID(Comando_SQL, "produto_valor_unitario");

            //*** Prepara o Comando para Inserção do Pedido ***
            Comando_SQL = "INSERT INTO itens(";
            Comando_SQL = Comando_SQL + "item_quantidade, ";
            Comando_SQL = Comando_SQL + "item_valor_total, ";
            Comando_SQL = Comando_SQL + "item_produto_codigo, ";
            Comando_SQL = Comando_SQL + "item_pedido_codigo) ";
            Comando_SQL = Comando_SQL + "VALUES(";
            Comando_SQL = Comando_SQL + "'1', ";
            Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaVirgulaPonto(ValorProduto) + "', ";
            Comando_SQL = Comando_SQL + "'" + CodigoProduto.Trim() + "', ";
            Comando_SQL = Comando_SQL + "'" + _frmPedido.txtPedidoTEXT.Trim() + "') ";

            //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
            objConexaoBanco.Executar_Comando(Comando_SQL);
        }
        #endregion

        #region CalculaTroco
        public void CalculaTroco(frmPedido _frmPedido)
        {
            //Declaração de Variáveis
            double vtxtReceber;
            double vPedido_Total;
            double vtxtTroco;

            //Inicialização de Variáveis
            vtxtReceber = 0;
            vPedido_Total = 0;
            vtxtTroco = 0;

            if (_frmPedido.Pedido_TotalTEXT.Trim() != "")
            {
                if (_frmPedido.txtReceberTEXT.Trim() != ",")
                {
                    //Carregamento de Variáveis
                    vPedido_Total = Convert.ToDouble(clsRotinasGerais.TrocaPontoVirgula(_frmPedido.Pedido_TotalTEXT));
                    vtxtReceber = Convert.ToDouble(clsRotinasGerais.TrocaPontoVirgula(_frmPedido.txtReceberTEXT));


                    if (vtxtReceber < vPedido_Total)
                    {
                        MessageBox.Show("O Valor Informado é Insuficiente.");
                    }

                    else
                    {
                        vtxtTroco = Convert.ToDouble(vtxtReceber - vPedido_Total);
                    }
                    _frmPedido.txtTrocoTEXT = Convert.ToString(vtxtTroco);
                }
                else
                {
                    MessageBox.Show("Incluir Valor Recebido!");
                }
            }
            else
            {
                MessageBox.Show("Inserir Item!");
            }
        }



        #endregion

        #region CarregarGrid
        public DataTable CarregarGrid(frmPedido _frmPedido)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca nas Tabelas de Itens e Produtos ***
            Comando_SQL = "SELECT ";
            Comando_SQL = Comando_SQL + "item_codigo, ";
            Comando_SQL = Comando_SQL + "item_quantidade, ";
            Comando_SQL = Comando_SQL + "item_produto_codigo, ";
            Comando_SQL = Comando_SQL + "CONCAT(produto_nome,' | ',produto_descricao,' | ',produto_tamanho) AS produto_descricao, ";
            Comando_SQL = Comando_SQL + "FORMAT(item_valor_total,2) AS item_valor_total ";
            Comando_SQL = Comando_SQL + "FROM itens,produtos ";
            Comando_SQL = Comando_SQL + "WHERE ";
            Comando_SQL = Comando_SQL + "item_produto_codigo = produto_codigo AND ";
            Comando_SQL = Comando_SQL + "item_pedido_codigo = " + _frmPedido.txtPedidoTEXT + " ";
            Comando_SQL = Comando_SQL + "ORDER BY item_codigo ASC";

            //*** Prepara o Data Grid ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            return ds.Tables[0];
        }
        #endregion

        #region TotalizaPedido
        public void TotalizaPedido(frmPedido _frmPedido)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca na Tabela de Clientes ***
            Comando_SQL = "SELECT ";
            Comando_SQL = Comando_SQL + "FORMAT(SUM(item_valor_total),2) AS item_valor_total ";
            Comando_SQL = Comando_SQL + "FROM itens ";
            Comando_SQL = Comando_SQL + "WHERE ";
            Comando_SQL = Comando_SQL + "item_pedido_codigo = " + _frmPedido.txtPedidoTEXT + " ";

            _frmPedido.Pedido_TotalTEXT = objConexaoBanco.Retorna_ID(Comando_SQL, "item_valor_total");
        }
        #endregion

        #region FormataGrid
        public void FormataGrid(frmPedido _frmPedido)
        {
            //*** Formata o Caption da Coluna no Data Grid ***
            _frmPedido.dgv_item_codigo_HEADERTEXT = "Item";
            _frmPedido.dgv_item_quantidade_HEADERTEXT = "Quantidade";
            _frmPedido.dgv_item_produto_codigo_HEADERTEXT = "Cód.Produto";
            _frmPedido.dgv_produto_descricao_HEADERTEXT = "Descrição";
            _frmPedido.dgv_item_valor_total_HEADERTEXT = "Preço";

            //*** Formata o Tamanho da Coluna no Data Grid ***
            _frmPedido.dgv_item_codigo_WIDTH = 123;
            _frmPedido.dgv_item_quantidade_WIDTH = 123;
            _frmPedido.dgv_item_produto_codigo_WIDTH = 150;
            _frmPedido.dgv_produto_descricao_WIDTH = 423;
            _frmPedido.dgv_item_valor_total_WIDTH = 100;

            //*** Deixa o Item Invisível ***
            _frmPedido.dgv_item_codigo_VISIBLE = false;
        }
        #endregion

        #region LimpaCampos
        //LIMPA CAMPO PARA USO DO COMANDO DE EXCLUSÃO <------- Rafael
        public void LimpaCampos(frmPedido _frmPedido)
        {
            //***Trava os Campos do Formulário **
            //_frmPedido.dgvPedidoENABLE = false;
        }
        #endregion

        #region EfetuaExclusao
        //EFETUA EXCLUSÃO DE ITENS DO DATAGRID <--------- Rafael
        public void EfetuaExclusao(frmPedido _frmPedido)
        {
            string Comando_SQL;

            if (_frmPedido.item_codigoExcluirTEXT.Trim() != "")
            {
                if (MessageBox.Show("Deseja Excluir o Item Número: " + _frmPedido.item_codigoExcluirTEXT.Trim() + " da Lista?", "Exclusão do Item", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                {
                    Comando_SQL = "DELETE FROM itens ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "item_codigo = '" + _frmPedido.item_codigoExcluirTEXT.Trim() + "'";

                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    MessageBox.Show("Item excluido da lista! ");

                    LimpaCampos(_frmPedido);
                }
            }
            else
            {
                MessageBox.Show(" Por Favor Selecione um Registro!");
            }
        }
        #endregion

        #region CarregaCamposGrid
        public void CarregaCamposGrid(frmPedido _frmPedido)
        {
            //*** Carrega os Campos da Linha que foi Clicada ***
            _frmPedido.item_codigoExcluirTEXT = _frmPedido.dgv_item_codigo_GRIDCLICK;
        }
        #endregion

        public void CarregarCliente(frmPedido _frmPedido)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca na Tabela de Clientes ***
            Comando_SQL = "SELECT ";
            Comando_SQL = Comando_SQL + "cliente_sequencial, ";
            Comando_SQL = Comando_SQL + "cliente_nome, ";
            Comando_SQL = Comando_SQL + "cliente_logradouro, ";
            Comando_SQL = Comando_SQL + "cliente_bairro, ";
            Comando_SQL = Comando_SQL + "cliente_ponto_referencia ";
            Comando_SQL = Comando_SQL + "FROM clientes ";
            Comando_SQL = Comando_SQL + "WHERE ";
            Comando_SQL = Comando_SQL + "cliente_telefone = '" + _frmPedido.txtTelefoneTEXT.Trim() + "' ";

            //*** Prepara o Data Grid ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();
            //string ValorRetorno;

            ds.Tables.Clear();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                _frmPedido.txtCodigo_ClienteTEXT = ds.Tables[0].Rows[0]["cliente_sequencial"].ToString();
                _frmPedido.txtClienteTEXT = ds.Tables[0].Rows[0]["cliente_nome"].ToString();
                _frmPedido.txtEnderecoTEXT = ds.Tables[0].Rows[0]["cliente_logradouro"].ToString();
                _frmPedido.txtBairroTEXT = ds.Tables[0].Rows[0]["cliente_bairro"].ToString();
                _frmPedido.txtPontoReferenciaTEXT = ds.Tables[0].Rows[0]["cliente_ponto_referencia"].ToString();
            }
            else
            {
                _frmPedido.txtCodigo_ClienteTEXT = "";
                _frmPedido.txtClienteTEXT = "";
                _frmPedido.txtEnderecoTEXT = "";
                _frmPedido.txtBairroTEXT = "";
                _frmPedido.txtPontoReferenciaTEXT = "";

                MessageBox.Show("Cliente não Cadastrado. Efetue o Cadastro!");
            }
        }

    }
}
