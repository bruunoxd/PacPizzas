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
using Entregas; // Esta é a Classe do Formulário de Clientes.

namespace PacPizzas
{
    public partial class frmEntregas : Form
    {
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsEntregas objEntregas = new clsEntregas();

        //*** Declara as Propriedades e Métodos do TexBox que 
        //*** serão utilizados pela Classe do Formulário ***
        //**********************************************
        //*** Propriedades dos Objetos do Formulário ***
        //**********************************************
        //*** txtPedido_Codigo ***
        public string txtPedido_CodigoTEXT
        {
            get { return txtPedido_Codigo.Text; }
            set { txtPedido_Codigo.Text = value; }
        }

        public bool txtPedido_CodigoENABLE
        {
            get { return txtPedido_Codigo.Enabled; }
            set { txtPedido_Codigo.Enabled = value; }
        }

        //*** txtPedido_Horario_Saida ***
        public string txtPedido_Horario_SaidaTEXT
        {
            get { return txtPedido_Horario_Saida.Text; }
            set { txtPedido_Horario_Saida.Text = value; }
        }

        public bool txtPedido_Horario_SaidaENABLE
        {
            get { return txtPedido_Horario_Saida.Enabled; }
            set { txtPedido_Horario_Saida.Enabled = value; }
        }

        //*** txtDataPedido ***
        public string txtDataPedidoTEXT
        {
            get { return txtDataPedido.Text; }
            set { txtDataPedido.Text = value; }
        }

        public bool txtDataPedidoENABLE
        {
            get { return txtDataPedido.Enabled; }
            set { txtDataPedido.Enabled = value; }
        }

        //*** txtPedido_CodigoFOCUS
        public void txtPedido_CodigoFOCUS()
        {
            this.txtPedido_Codigo.Focus();
        }
        
        
        
        //*** dgvRegistros ***
        //*** DataSource ***
        public DataTable dgvRegistrosDATASOURCE
        {
            set { dgvRegistros.DataSource = value; }
        }
        #region Pedido Código
        //*** produto_codigo ***
        public string dgvRegistros_pedido_codigo_HEADERTEXT
        {
            get { return dgvRegistros.Columns["pedido_codigo"].HeaderText; }
            set { dgvRegistros.Columns["pedido_codigo"].HeaderText = value; }
        }

        public int dgvRegistros_pedido_codigo_WIDTH
        {
            get { return dgvRegistros.Columns["pedido_codigo"].Width; }
            set { dgvRegistros.Columns["pedido_codigo"].Width = value; }
        }

        public string dgvRegistros_pedido_codigo_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[0].Value.ToString(); }
        }
        #endregion
        #region Pedido Data
        //*** pedido_data
        public string dgvRegistros_pedido_data_HEADERTEXT
        {
            get { return dgvRegistros.Columns["pedido_data"].HeaderText; }
            set { dgvRegistros.Columns["pedido_data"].HeaderText = value; }
        }

        public int dgvRegistros_pedido_data_WIDTH
        {
            get { return dgvRegistros.Columns["pedido_data"].Width; }
            set { dgvRegistros.Columns["pedido_data"].Width = value; }
        }

        public string dgvRegistros_pedido_data_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[1].Value.ToString(); }
        }
        #endregion
        #region Pedido Horario
        //*** pedido_horario
        public string dgvRegistros_pedido_horario_HEADERTEXT
        {
            get { return dgvRegistros.Columns["pedido_horario"].HeaderText; }
            set { dgvRegistros.Columns["pedido_horario"].HeaderText = value; }
        }

        public int dgvRegistros_pedido_horario_WIDTH
        {
            get { return dgvRegistros.Columns["pedido_horario"].Width; }
            set { dgvRegistros.Columns["pedido_horario"].Width = value; }
        }

        public string dgvRegistros_pedido_horario_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[2].Value.ToString(); }
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
            get { return dgvRegistros.CurrentRow.Cells[3].Value.ToString(); }
        }
        #endregion
        #region Pedido Funcionario CPF
        //*** pedido_funcionario_cpf
        public string dgvRegistros_pedido_funcionario_cpf_HEADERTEXT
        {
            get { return dgvRegistros.Columns["pedido_funcionario_cpf"].HeaderText; }
            set { dgvRegistros.Columns["pedido_funcionario_cpf"].HeaderText = value; }
        }

        public int dgvRegistros_pedido_funcionario_cpf_WIDTH
        {
            get { return dgvRegistros.Columns["pedido_funcionario_cpf"].Width; }
            set { dgvRegistros.Columns["pedido_funcionario_cpf"].Width = value; }
        }

        public string dgvRegistros_pedido_funcionario_cpfGRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[4].Value.ToString(); }
        }
        #endregion
        #region Pedido Horario Saida
        //*** pedido_horario_saida
        public string dgvRegistros_pedido_horario_saida_HEADERTEXT
        {
            get { return dgvRegistros.Columns["pedido_horario_saida"].HeaderText; }
            set { dgvRegistros.Columns["pedido_horario_saida"].HeaderText = value; }
        }

        public int dgvRegistros_pedido_horario_saida_WIDTH
        {
            get { return dgvRegistros.Columns["pedido_horario_saida"].Width; }
            set { dgvRegistros.Columns["pedido_horario_saida"].Width = value; }
        }

        public string dgvRegistros_pedido_horario_saida_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[5].Value.ToString(); }
        }
        #endregion




        //*****************************************
        //*** Métodos dos Objetos do Formulário ***
        //*****************************************

        #region Declaração de FOCUS
        //*** txtBuscarPor ***
        public void txtDataPedidoFOCUS()
        {
            this.txtDataPedido.Focus();
        }
        #endregion
        //*****************************
        //*** Métodos do Formulário ***
        //*****************************
        public frmEntregas()
        {
            InitializeComponent();
        }


        //private void cmbProcurarEm_KeyDown(object sender, KeyEventArgs e)
        //{
        //    clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        //}

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
            dgvRegistros.DataSource = objEntregas.CarregarGrid(txtDataPedido.Text);
            objEntregas.FormataGrid(this);
            objEntregas.LimpaCampos(this);
        }


        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //*** Carrega os Campos da Linha que foi Clicada no Grid ***
            objEntregas.CarregarCamposGrid(this);
        }

        //*** Referência Botão Ajuda
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Referência no Manual Pac Pizzas" + Convert.ToChar(13) + Convert.ToChar(10) +
                "Pagina: ");
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            //*** Processa o Método de Gravação Identificando se é uma 
            //*** Inclusão ou Alteração
            objEntregas.EfetuaGravacao(this);
        }

        private void frmEntregas_Load(object sender, EventArgs e)
        {
            //*** Prepara a Busca Inicial no Grid ***
            dgvRegistros.DataSource = objEntregas.CarregarGrid(txtDataPedido.Text);
            objEntregas.FormataGrid(this);

            //*** Desativa o Campo para Digitação ***
            txtPedido_Codigo.Enabled = false;
            txtPedido_Horario_Saida.Enabled = false;

            //*** Preenche a Data Atual para os TextBox de Período de Datas.   ***
            //*** A "@" permitirá a Formatação da Data para o Padrão Desejado. ***
            txtPedido_Horario_Saida.Text = DateTime.Now.ToString(@"HH:mm:ss");
            txtDataPedido.Text = DateTime.Now.ToString(@"dd/MM/yyyy");
        }

        private void txtDataPedido_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            //*** Abre o Formulário Visualizar Itens do Pedido
            frmVisualizar _frmVisualizar = new frmVisualizar();
            _frmVisualizar.ShowDialog();
        }
    }
}
