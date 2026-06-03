using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//**************************************************************
//*** Habilita as Referências (Namespace) a serem utilizadas ***
//**************************************************************
//*** A palavra-chave de namespace (Referência) é usada para
//*** declarar um escopo que contém um conjunto de objetos
//*** relacionados. Você pode usar um namespace para organizar
//*** elementos de código e para criar globalmente tipos 
//*** exclusivos.
using RotinasGerais; // Este é o Módulo de Visão Global.
using ConexaoBanco; // Esta é a Classe de Conexão com o Banco de Dados.
using Visualizar; // Esta é a Classe do Formulário de Clientes.

namespace PacPizzas
{
    public partial class frmVisualizar : Form
    {
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsVisualizar objVisualizar = new clsVisualizar();

        //*** Declara as Propriedades e Métodos do TexBox que 
        //*** serão utilizados pela Classe do Formulário ***
        //**********************************************
        //*** Propriedades dos Objetos do Formulário ***
        //**********************************************
        //*** txtPedido_Codigo ***
        public string txtNomeTEXT
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }

        public bool txtNomeENABLE
        {
            get { return txtNome.Enabled; }
            set { txtNome.Enabled = value; }
        }

        //*** txtCliente_Logradouro ***
        public string txtCliente_LogradouroTEXT
        {
            get { return txtCliente_Logradouro.Text; }
            set { txtCliente_Logradouro.Text = value; }
        }

        public bool txtCliente_LogradouroENABLE
        {
            get { return txtCliente_Logradouro.Enabled; }
            set { txtCliente_Logradouro.Enabled = value; }
        }

        //*** txtCliente_Numero ***
        public string txtCliente_Numero_ResidenciaTEXT
        {
            get { return txtCliente_Numero_Residencia.Text; }
            set { txtCliente_Numero_Residencia.Text = value; }
        }

        public bool txtCliente_Numero_ResidenciaENABLE
        {
            get { return txtCliente_Numero_Residencia.Enabled; }
            set { txtCliente_Numero_Residencia.Enabled = value; }
        }

        //*** txtCliente_Complemento ***
        public string txtCliente_ComplementoTEXT
        {
            get { return txtCliente_Complemento.Text; }
            set { txtCliente_Complemento.Text = value; }
        }

        public bool txtCliente_ComplementoENABLE
        {
            get { return txtCliente_Complemento.Enabled; }
            set { txtCliente_Complemento.Enabled = value; }
        }

        //*** txtCliente_Bairro ***
        public string txtCliente_BairroTEXT
        {
            get { return txtCliente_Bairro.Text; }
            set { txtCliente_Bairro.Text = value; }
        }

        public bool txtCliente_BairroENABLE
        {
            get { return txtCliente_Bairro.Enabled; }
            set { txtCliente_Bairro.Enabled = value; }
        }

        //*** txtCliente_Ponto_Referencia ***
        public string txtCliente_Ponto_ReferenciaTEXT
        {
            get { return txtCliente_Ponto_Referencia.Text; }
            set { txtCliente_Ponto_Referencia.Text = value; }
        }

        public bool txtCliente_Ponto_ReferenciaENABLE
        {
            get { return txtCliente_Ponto_Referencia.Enabled; }
            set { txtCliente_Ponto_Referencia.Enabled = value; }
        }

        //*** txtNumero_Pedido ***
        public string txtNumero_PedidoTEXT
        {
            get { return txtNumero_Pedido.Text; }
            set { txtNumero_Pedido.Text = value; }
        }

        public bool txtNumero_PedidoENABLE
        {
            get { return txtNumero_Pedido.Enabled; }
            set { txtNumero_Pedido.Enabled = value; }
        }

        //*** dgvRegistros ***
        //*** DataSource ***
        public DataTable dgvRegistrosDATASOURCE
        {
            set { dgvRegistros.DataSource = value; }
        }
        #region Item Pedido Código
        //*** item_pedido_codigo ***
        public string dgvRegistros_item_pedido_codigo_HEADERTEXT
        {
            get { return dgvRegistros.Columns["item_pedido_codigo"].HeaderText; }
            set { dgvRegistros.Columns["item_pedido_codigo"].HeaderText = value; }
        }

        public int dgvRegistros_item_pedido_codigo_WIDTH
        {
            get { return dgvRegistros.Columns["item_pedido_codigo"].Width; }
            set { dgvRegistros.Columns["item_pedido_codigo"].Width = value; }
        }

        public string dgvRegistros_item_pedido_codigo_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[0].Value.ToString(); }
        }
        #endregion
        #region Pedido Cliente Sequencial
        //*** pedido_cliente_sequencial
        public string dgvRegistros_pedido_cliente_sequencial_HEADERTEXT
        {
            get { return dgvRegistros.Columns["pedido_cliente_sequencial"].HeaderText; }
            set { dgvRegistros.Columns["pedido_cliente_sequencial"].HeaderText = value; }
        }

        public int dgvRegistros_pedido_cliente_sequencial_WIDTH
        {
            get { return dgvRegistros.Columns["pedido_cliente_sequencial"].Width; }
            set { dgvRegistros.Columns["pedido_cliente_sequencial"].Width = value; }
        }

        public string dgvRegistros_pedido_cliente_sequencial_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[1].Value.ToString(); }
        }

        //*** Deixa o Campo no Grid INVISIVEL
        public bool dgv_pedido_cliente_sequencial_VISIBLE
        {
            set { dgvRegistros.Columns["pedido_cliente_sequencial"].Visible = value; }
        }
        #endregion
        #region Item Produto Codigo
        //*** item_produto_codigo
        public string dgvRegistros_item_produto_codigo_HEADERTEXT
        {
            get { return dgvRegistros.Columns["item_produto_codigo"].HeaderText; }
            set { dgvRegistros.Columns["item_produto_codigo"].HeaderText = value; }
        }

        public int dgvRegistros_item_produto_codigo_WIDTH
        {
            get { return dgvRegistros.Columns["item_produto_codigo"].Width; }
            set { dgvRegistros.Columns["item_produto_codigo"].Width = value; }
        }

        public string dgvRegistros_item_produto_codigo_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[2].Value.ToString(); }
        }
        #endregion
        #region Produto Nome
        //*** produto_nome
        public string dgvRegistros_produto_nome_HEADERTEXT
        {
            get { return dgvRegistros.Columns["produto_nome"].HeaderText; }
            set { dgvRegistros.Columns["produto_nome"].HeaderText = value; }
        }

        public int dgvRegistros_produto_nome_WIDTH
        {
            get { return dgvRegistros.Columns["produto_nome"].Width; }
            set { dgvRegistros.Columns["produto_nome"].Width = value; }
        }

        public string dgvRegistros_produto_nome_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[3].Value.ToString(); }
        }
        #endregion
        #region Produto Descrição
        //*** produto_descricao
        public string dgvRegistros_produto_descricao_HEADERTEXT
        {
            get { return dgvRegistros.Columns["produto_descricao"].HeaderText; }
            set { dgvRegistros.Columns["produto_descricao"].HeaderText = value; }
        }

        public int dgvRegistros_produto_descricao_WIDTH
        {
            get { return dgvRegistros.Columns["produto_descricao"].Width; }
            set { dgvRegistros.Columns["produto_descricao"].Width = value; }
        }

        public string dgvRegistros_produto_descricao_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[4].Value.ToString(); }
        }
        #endregion
        #region Produto Tamanho
        //*** produto_tamanho
        public string dgvRegistros_produto_tamanho_HEADERTEXT
        {
            get { return dgvRegistros.Columns["produto_tamanho"].HeaderText; }
            set { dgvRegistros.Columns["produto_tamanho"].HeaderText = value; }
        }

        public int dgvRegistros_produto_tamanho_WIDTH
        {
            get { return dgvRegistros.Columns["produto_tamanho"].Width; }
            set { dgvRegistros.Columns["produto_tamanho"].Width = value; }
        }

        public string dgvRegistros_produto_tamanho_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[5].Value.ToString(); }
        }
        #endregion
        
        #region Item Quantidade
        //*** item_quantidade
        public string dgvRegistros_item_quantidade_HEADERTEXT
        {
            get { return dgvRegistros.Columns["item_quantidade"].HeaderText; }
            set { dgvRegistros.Columns["item_quantidade"].HeaderText = value; }
        }

        public int dgvRegistros_item_quantidade_WIDTH
        {
            get { return dgvRegistros.Columns["item_quantidade"].Width; }
            set { dgvRegistros.Columns["item_quantidade"].Width = value; }
        }

        public string dgvRegistros_item_quantidade_cpfGRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[6].Value.ToString(); }
        }
        #endregion
        #region Cliente Nome
        //*** cliente_nome
        public string dgvRegistros_cliente_nome_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_nome"].HeaderText; }
            set { dgvRegistros.Columns["cliente_nome"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_nome_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_nome"].Width; }
            set { dgvRegistros.Columns["cliente_nome"].Width = value; }
        }

        public string dgvRegistros_cliente_nome_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[7].Value.ToString(); }
        }
        //*** Deixa o Campo no Grid INVISIVEL
        public bool dgv_cliente_nome_VISIBLE
        {
            set { dgvRegistros.Columns["cliente_nome"].Visible = value; }
        }
        #endregion
        #region Cliente Logradouro
        //*** cliente_logradouro
        public string dgvRegistros_cliente_logradouro_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_logradouro"].HeaderText; }
            set { dgvRegistros.Columns["cliente_logradouro"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_logradouro_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_logradouro"].Width; }
            set { dgvRegistros.Columns["cliente_logradouro"].Width = value; }
        }

        public string dgvRegistros_cliente_logradouro_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[8].Value.ToString(); }
        }
        //*** Deixa o Campo no Grid INVISIVEL
        public bool dgv_cliente_logradouro_VISIBLE
        {
            set { dgvRegistros.Columns["cliente_logradouro"].Visible = value; }
        }
        #endregion
        #region Cliente Numero Residencia
        //*** cliente_numero
        public string dgvRegistros_cliente_numero_residencia_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_numero_residencia"].HeaderText; }
            set { dgvRegistros.Columns["cliente_numero_residencia"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_numero_residencia_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_numero_residencia"].Width; }
            set { dgvRegistros.Columns["cliente_numero_residencia"].Width = value; }
        }

        public string dgvRegistros_cliente_numero_residencia_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[9].Value.ToString(); }
        }
        //*** Deixa o Campo no Grid INVISIVEL
        public bool dgv_cliente_numero_residencia_VISIBLE
        {
            set { dgvRegistros.Columns["cliente_numero_residencia"].Visible = value; }
        }
        #endregion
        #region Cliente Complemento
        //*** cliente_complemento
        public string dgvRegistros_cliente_complemento_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_complemento"].HeaderText; }
            set { dgvRegistros.Columns["cliente_complemento"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_complemento_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_complemento"].Width; }
            set { dgvRegistros.Columns["cliente_complemento"].Width = value; }
        }

        public string dgvRegistros_cliente_complemento_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[10].Value.ToString(); }
        }
        //*** Deixa o Campo no Grid INVISIVEL
        public bool dgv_cliente_complemento_VISIBLE
        {
            set { dgvRegistros.Columns["cliente_complemento"].Visible = value; }
        }
        #endregion
        #region Cliente Bairro
        //*** cliente_bairro
        public string dgvRegistros_cliente_bairro_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_bairro"].HeaderText; }
            set { dgvRegistros.Columns["cliente_bairro"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_bairro_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_bairro"].Width; }
            set { dgvRegistros.Columns["cliente_bairro"].Width = value; }
        }

        public string dgvRegistros_cliente_bairro_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[11].Value.ToString(); }
        }
        //*** Deixa o Campo no Grid INVISIVEL
        public bool dgv_cliente_bairro_VISIBLE
        {
            set { dgvRegistros.Columns["cliente_bairro"].Visible = value; }
        }
        #endregion
        #region Cliente Ponto Referência
        //*** cliente_ponto_referencia
        public string dgvRegistros_cliente_ponto_referencia_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_ponto_referencia"].HeaderText; }
            set { dgvRegistros.Columns["cliente_ponto_referencia"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_ponto_referencia_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_ponto_referencia"].Width; }
            set { dgvRegistros.Columns["cliente_ponto_referencia"].Width = value; }
        }

        public string dgvRegistros_cliente_ponto_referencia_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[12].Value.ToString(); }
        }
        //*** Deixa o Campo no Grid INVISIVEL
        public bool dgv_cliente_ponto_referencia_VISIBLE
        {
            set { dgvRegistros.Columns["cliente_ponto_referencia"].Visible = value; }
        }
        #endregion


        //*****************************************
        //*** Métodos dos Objetos do Formulário ***
        //*****************************************

        #region Declaração de FOCUS
        //*** txtNumero_Pedido ***
        public void txtNumero_PedidoFOCUS()
        {
            this.txtNumero_Pedido.Focus();
        }
        #endregion
        //*****************************
        //*** Métodos do Formulário ***
        //*****************************
        public frmVisualizar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //*** Fecha apenas este Formulário
            //*** Tira o Formulário da Memória ***
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //*** Realiza a Busca na Tabela de Pedidos
            //*** e Mostra o resultado no Grid ***
            dgvRegistros.DataSource = objVisualizar.CarregarGrid(txtNumero_Pedido.Text);
            objVisualizar.FormataGrid(this);
            objVisualizar.LimpaCampos(this);
        }


        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //*** Carrega os Campos da Linha que foi Clicada no Grid ***
            objVisualizar.CarregarCamposGrid(this);
        }

        //*** Referência Botão Ajuda
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Referência no Manual Pac Pizzas" + Convert.ToChar(13) + Convert.ToChar(10) +
                "Pagina: ");
        }

        private void frmVisualizar_Load(object sender, EventArgs e)
        {
                //*** Prepara a Busca Inicial no Grid ***
                dgvRegistros.DataSource = objVisualizar.CarregarGrid(txtNumero_Pedido.Text);
                objVisualizar.FormataGrid(this);

                //*** Desativa o Campo para Digitação ***
                txtNome.Enabled = false;
                txtCliente_Logradouro.Enabled = false;
                txtCliente_Numero_Residencia.Enabled = false;
                txtCliente_Complemento.Enabled = false;
                txtCliente_Bairro.Enabled = false;
                txtCliente_Ponto_Referencia.Enabled = false;
        }

        private void txtNumero_Pedido_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }
    }
}
