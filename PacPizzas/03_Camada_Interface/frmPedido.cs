using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RotinasGerais; //*** Este é o Modulo de Visão Global
using ConexaoBanco; //*** Esta é a Classe de Conexão com o Banco de Dados
using Pedido;
using Clientes;
using PacPizzas;

namespace PacPizzas
{
    public partial class frmPedido : Form
    {

        //* Instâncias os Objetos da Classes Correspondentes 
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsPedido objPedido = new clsPedido();

        //** Declara as Propriedades e Métodos do TexBox que serão utilizados pela classe do Fórmularios
        //** Propriedades dos Objetos do Formularios  ***txtUsuario_Login ***

        //**************** GETS E SETS do Formulário ****************

        #region item_codigoExcluirTEXT
        public string item_codigoExcluirTEXT
        {
            get { return item_codigoExcluir.Text; }
            set { item_codigoExcluir.Text = value; }
        }
        #endregion

        #region txtPedidoTEXT
        public string txtPedidoTEXT
        {
            get { return txtPedido.Text; }
            set { txtPedido.Text = value; }
        }
        #endregion

        


        #region txtDataTEXT
        public string txtDataTEXT
        {
            get { return txtData.Text; }
            set { txtData.Text = value; }
        }
        #endregion

        #region txtHorarioTEXT
        public string txtHorarioTEXT
        {
            get { return txtHorario.Text; }
            set { txtHorario.Text = value; }
        }
        #endregion

        #region txtCPFTEXT
        public string txtCPFTEXT
        {
            get { return txtCPF.Text; }
            set { txtCPF.Text = value; }
        }
        #endregion

        #region txtCodigo_ClienteTEXT
        public string txtCodigo_ClienteTEXT
        {
            get { return txtCodigo_Cliente.Text; }
            set { txtCodigo_Cliente.Text = value; }
        }
        #endregion

        #region cbpedido_pizza
        public string cbpedido_pizzaTEXT
        {
            get { return cbpedido_pizza.Text; }
            set { cbpedido_pizza.Text = value; }
        }

        public bool cbpedido_pizzaENABLE
        {
            get { return cbpedido_pizza.Enabled; }
            set { cbpedido_pizza.Enabled = value; }
        }

        public DataTable cbpedido_pizzaDATASOURCE
        {
            set { cbpedido_pizza.DataSource = value; }
        }

        public string cbpedido_pizzaDISPLAYMEMBER
        {
            set { cbpedido_pizza.DisplayMember = value; }
        }

        public string cbpedido_pizzaVALUEMEMBER
        {
            set { cbpedido_pizza.ValueMember = value; }
        }

        public void cbpedido_pizzaFOCUS()
        {
            cbpedido_pizza.Focus();
        }

        #endregion

        #region cbQuantidade
        public string cbQuantidadeTEXT
        {
            get { return cbQuantidade.Text; }
            set { cbQuantidade.Text = value; }
        }
        public bool cbQuantidadeENABLE
        {
            get { return cbQuantidade.Enabled; }
            set { cbQuantidade.Enabled = value; }
        }
        #endregion

        #region cbpedido_produto
        public string cbpedido_produtoTEXT
        {
            get { return cbpedido_produto.Text; }
            set { cbpedido_produto.Text = value; }
        }
        public bool cbpedido_produtoENABLE
        {
            get { return cbpedido_produto.Enabled; }
            set { cbpedido_produto.Enabled = value; }
        }
        public DataTable cbpedido_produtoDATASOURCE
        {
            set { cbpedido_produto.DataSource = value; }
        }

        public string cbpedido_produtoDISPLAYMEMBER
        {
            set { cbpedido_produto.DisplayMember = value; }
        }

        public string cbpedido_produtoVALUEMEMBER
        {
            set { cbpedido_produto.ValueMember = value; }
        }

        public void cbpedido_produtoFOCUS()
        {
            cbpedido_produto.Focus();
        }
        #endregion

        #region txtCliente
        public string txtClienteTEXT
        {
            get { return txtCliente.Text; }
            set { txtCliente.Text = value; }
        }

        public bool txtClienteENABLE
        {
            get { return txtCliente.Enabled; }
            set { txtCliente.Enabled = value; }
        }
        #endregion

        #region txtcliente_codigo
        public string txtcliente_codigoTEXT
        {
            get { return txtCodigo_Cliente.Text; }
            set { txtCodigo_Cliente.Text = value; }
        }

        public bool txtcliente_codigoENABLE
        {
            get { return txtCodigo_Cliente.Enabled; }
            set { txtCodigo_Cliente.Enabled = value; }
        }
        #endregion

        #region txtEndereco
        public string txtEnderecoTEXT
        {
            get { return txtEndereco.Text; }
            set { txtEndereco.Text = value; }
        }

        public bool txtEnderecoENABLE
        {
            get { return txtEndereco.Enabled; }
            set { txtEndereco.Enabled = value; }
        }
        #endregion

        #region txtBairro
        public string txtBairroTEXT
        {
            get { return txtBairro.Text; }
            set { txtBairro.Text = value; }
        }

        public bool txtBairroENABLE
        {
            get { return txtBairro.Enabled; }
            set { txtBairro.Enabled = value; }
        }
        #endregion

        #region txtPontoReferencia
        public string txtPontoReferenciaTEXT
        {
            get { return txtPontoReferencia.Text; }
            set { txtPontoReferencia.Text = value; }
        }

        public bool txtPontoReferenciaENABLE
        {
            get { return txtPontoReferencia.Enabled; }
            set { txtPontoReferencia.Enabled = value; }
        }
        #endregion

        #region btnBuscar
        //public string btnBuscarTEXT
        //{
        //  get { return btnBuscar.Text; }
        //set { btnBuscar.Text = value; }
        //}

        //public bool btnBuscarENABLE
        //{
        //  get { return btnBuscar.Enabled; }
        //set { btnBuscar.Enabled = value; }
        //}
        #endregion

        #region txtTelefone
        public string txtTelefoneTEXT
        {
            get { return txtTelefone.Text; }
            set { txtTelefone.Text = value; }
        }

        public bool txtTelefoneENABLE
        {
            get { return txtTelefone.Enabled; }
            set { txtTelefone.Enabled = value; }
        }
        #endregion
        #region FOCUS
        //*** txtTelefoneFOCUS
        public void txtTelefoneFOCUS()
        {
            this.txtTelefone.Focus();
        }

        //*** Pedido_TotalFOCUS
        public void Pedido_TotalFOCUS()
        {
            this.Pedido_Total.Focus();
        }
        
        #endregion
        #region clsTroco
        public string txtReceberTEXT
        {
            get { return txtReceber.Text; }
            set { txtReceber.Text = value; }
        }
        public bool txtReceberENABLE
        {
            get { return txtReceber.Enabled; }
            set { txtReceber.Enabled = value; }
        }

        public string Pedido_TotalTEXT
        {
            get { return Pedido_Total.Text; }
            set { Pedido_Total.Text = value; }
        }
        public bool Pedido_TotalENABLE
        {
            get { return Pedido_Total.Enabled; }
            set { Pedido_Total.Enabled = value; }
        }

        public string txtTrocoTEXT
        {
            get { return txtTroco.Text; }
            set { txtTroco.Text = value; }
        }
        public bool txtTrocoENABLE
        {
            get { return txtTroco.Enabled; }
            set { txtTroco.Enabled = value; }
        }
        #endregion

        //*** dgvPedido ***
        //*** DataSource ***
        public DataTable dgvPedidoDATASOURCE
        {
            set { dgvPedido.DataSource = value; }
        }

        #region dgv_item_codigo
        //*** produto_codigo ***
        public string dgv_item_codigo_HEADERTEXT
        {
            get { return dgvPedido.Columns["item_codigo"].HeaderText; }
            set { dgvPedido.Columns["item_codigo"].HeaderText = value; }
        }

        public int dgv_item_codigo_WIDTH
        {
            get { return dgvPedido.Columns["item_codigo"].Width; }
            set { dgvPedido.Columns["item_codigo"].Width = value; }
        }

        public string dgv_item_codigo_GRIDCLICK
        {
            get { return dgvPedido.CurrentRow.Cells[0].Value.ToString(); }
        }

        public bool dgv_item_codigo_VISIBLE
        {
            set { dgvPedido.Columns["item_codigo"].Visible = value; }
        }
        #endregion

        #region dgv_item_quantidade
        public string dgv_item_quantidade_HEADERTEXT
        {
            get { return dgvPedido.Columns["item_quantidade"].HeaderText; }
            set { dgvPedido.Columns["item_quantidade"].HeaderText = value; }
        }

        public int dgv_item_quantidade_WIDTH
        {
            get { return dgvPedido.Columns["item_quantidade"].Width; }
            set { dgvPedido.Columns["item_quantidade"].Width = value; }
        }

        public string dgv_item_quantidade_GRIDCLICK
        {
            get { return dgvPedido.CurrentRow.Cells[1].Value.ToString(); }
        }
        #endregion

        #region dgv_item_produto_codigo
        public string dgv_item_produto_codigo_HEADERTEXT
        {
            get { return dgvPedido.Columns["item_produto_codigo"].HeaderText; }
            set { dgvPedido.Columns["item_produto_codigo"].HeaderText = value; }
        }

        public int dgv_item_produto_codigo_WIDTH
        {
            get { return dgvPedido.Columns["item_produto_codigo"].Width; }
            set { dgvPedido.Columns["item_produto_codigo"].Width = value; }
        }

        public string dgv_item_produto_codigo_GRIDCLICK
        {
            get { return dgvPedido.CurrentRow.Cells[2].Value.ToString(); }
        }
        #endregion

        #region dgv_produto_descricao
        public string dgv_produto_descricao_HEADERTEXT
        {
            get { return dgvPedido.Columns["produto_descricao"].HeaderText; }
            set { dgvPedido.Columns["produto_descricao"].HeaderText = value; }
        }

        public int dgv_produto_descricao_WIDTH
        {
            get { return dgvPedido.Columns["produto_descricao"].Width; }
            set { dgvPedido.Columns["produto_descricao"].Width = value; }
        }

        public string dgv_produto_descricao_GRIDCLICK
        {
            get { return dgvPedido.CurrentRow.Cells[3].Value.ToString(); }
        }
        #endregion

        #region dgv_item_valor_total
        public string dgv_item_valor_total_HEADERTEXT
        {
            get { return dgvPedido.Columns["item_valor_total"].HeaderText; }
            set { dgvPedido.Columns["item_valor_total"].HeaderText = value; }
        }

        public int dgv_item_valor_total_WIDTH
        {
            get { return dgvPedido.Columns["item_valor_total"].Width; }
            set { dgvPedido.Columns["item_valor_total"].Width = value; }
        }

        public string dgv_item_valor_total_GRIDCLICK
        {
            get { return dgvPedido.CurrentRow.Cells[4].Value.ToString(); }
        }
        #endregion

        public void InicializaPedido()
        {
            //*** Carrega os Campos com os Valores de Data, Hora e Funcionário ***
            txtCPF.Text = clsRotinasGerais.CPFFuncionario;
            txtData.Text = DateTime.Now.ToString(@"dd/MM/yyyy");
            txtHorario.Text = DateTime.Now.ToString(@"HH:mm:ss");

            //*** Carrega o ComboBox com os Produtos ***
            objPedido.CarregaComboPizza(this);
            objPedido.CarregaComboProduto(this);
            if (cbpedido_pizza.Items.Count > 0) cbpedido_pizza.SelectedIndex = 0;
            if (cbpedido_produto.Items.Count > 0) cbpedido_produto.SelectedIndex = 0;
            if (cbQuantidade.Items.Count > 0) cbQuantidade.SelectedIndex = 1;

            //*** Cria o Pedido ***
            objPedido.CriarPedido(this);
        }


        //****************************************************************************
        public frmPedido()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            InicializaPedido();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objPedido.CarregarCliente(this);
        }

        private void btnIncluirPizza_Click(object sender, EventArgs e)
        {
            objPedido.InsereItemPizza(this);
            dgvPedido.DataSource = objPedido.CarregarGrid(this);
            objPedido.FormataGrid(this);
            objPedido.TotalizaPedido(this);
        }

       
        private void btnExcluirItens_Click(object sender, EventArgs e)
        {

            txtTrocoTEXT = "";
            txtReceberTEXT = "";

            objPedido.EfetuaExclusao(this);

            dgvPedido.DataSource = objPedido.CarregarGrid(this);
            objPedido.FormataGrid(this);
            objPedido.TotalizaPedido(this);


        }
        private void txtReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) //** O Valor do Enter é 13 troca o Enter pelo TAB
            {

                objPedido.CalculaTroco(this);

                SendKeys.Send("{TAB}"); //*** Caso a tecla ENTER seja utilizada o Sistema envia um sinal 
                //*** substituíndo a tecla ENTER pelo TAB ***
            }
        }
       

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar o Pedido?", "PacPizza", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                if (objPedido.ValidaDados(this) == true)
                {
                 
                    objPedido.FinalizarPedido(this);

                    txtcliente_codigoTEXT = "";
                    item_codigoExcluirTEXT = "";
                    Pedido_TotalTEXT = "";
                    txtTrocoTEXT = "";
                    txtReceberTEXT = "";
                    txtPedidoTEXT = "";
                    txtTelefoneTEXT = "";
                    txtClienteTEXT = "";
                    txtEnderecoTEXT = "";
                    txtBairroTEXT = "";
                    txtPontoReferenciaTEXT = "";

                    MessageBox.Show("Pedido Finalizado!");

                    InicializaPedido();
                    dgvPedido.DataSource = objPedido.CarregarGrid(this);
                    objPedido.FormataGrid(this);
                    objPedido.TotalizaPedido(this);
                }

                txtTelefone.Focus();
            }
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            objPedido.InsereItemProduto(this);
            dgvPedido.DataSource = objPedido.CarregarGrid(this);
            objPedido.FormataGrid(this);
            objPedido.TotalizaPedido(this);
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            objPedido.CarregaCamposGrid(this);
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            frmClientes _frmClientes = new frmClientes();
            _frmClientes.ShowDialog();
        }
        //*** Referência Botão Ajuda
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Referência no Manual Pac Pizzas" + Convert.ToChar(13) + Convert.ToChar(10) +
                "Pagina: ");
        }

        private void btnCalcula_Troco_Click(object sender, EventArgs e)
        {
            objPedido.CalculaTroco(this);
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            //*** Abre o Formulário Visualizar Itens do Pedido
            frmVisualizar _frmVisualizar = new frmVisualizar();
            _frmVisualizar.ShowDialog();
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            //*** Abre o Formulário de Entregas
            frmEntregas _frmEntregas = new frmEntregas();
            _frmEntregas.ShowDialog();
        }


        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void cbpedido_pizza_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void cbQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void cbpedido_produto_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        
    }
}
