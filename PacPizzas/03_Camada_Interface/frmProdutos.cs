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
using Produtos; // Esta é a Classe do Formulário de Clientes.

namespace PacPizzas
{
    public partial class frmProdutos : Form
    {
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsProdutos objProdutos = new clsProdutos();

        //*** Declara as Propriedades e Métodos do TexBox que 
        //*** serão utilizados pela Classe do Formulário ***
        //**********************************************
        //*** Propriedades dos Objetos do Formulário ***
        //**********************************************
        //*** txtProduto_Codigo ***
        public string txtProduto_CodigoTEXT
        {
            get { return txtProduto_Codigo.Text; }
            set { txtProduto_Codigo.Text = value; }
        }

        public bool txtProduto_CodigoENABLE
        {
            get { return txtProduto_Codigo.Enabled; }
            set { txtProduto_Codigo.Enabled = value; }
        }

        //*** txtProduto_Nome ***
        public string txtProduto_NomeTEXT
        {
            get { return txtProduto_Nome.Text; }
            set { txtProduto_Nome.Text = value; }
        }

        public bool txtProduto_NomeENABLE
        {
            get { return txtProduto_Nome.Enabled; }
            set { txtProduto_Nome.Enabled = value; }
        }

        //*** txtProduto_Tamanho ***
        public string txtProduto_TamanhoTEXT
        {
            get { return txtProduto_Tamanho.Text; }
            set { txtProduto_Tamanho.Text = value; }
        }

        public bool txtProduto_TamanhoENABLE
        {
            get { return txtProduto_Tamanho.Enabled; }
            set { txtProduto_Tamanho.Enabled = value; }
        }

        //*** txtProduto_Valor_Unitario ***
        public string txtProduto_Valor_UnitarioTEXT
        {
            get { return txtProduto_Valor_Unitario.Text; }
            set { txtProduto_Valor_Unitario.Text = value; }
        }

        public bool txtProduto_Valor_UnitarioENABLE
        {
            get { return txtProduto_Valor_Unitario.Enabled; }
            set { txtProduto_Valor_Unitario.Enabled = value; }
        }

        //*** txtProduto_Descricao ***
        public string txtProduto_DescricaoTEXT
        {
            get { return txtProduto_Descricao.Text; }
            set { txtProduto_Descricao.Text = value; }
        }

        public bool txtProduto_DescricaoENABLE
        {
            get { return txtProduto_Descricao.Enabled; }
            set { txtProduto_Descricao.Enabled = value; }
        }

        //*** txtBuscarPor ***
        public string txtBuscarPorTEXT
        {
            get { return txtBuscarPor.Text; }
            set { txtBuscarPor.Text = value; }
        }

        public bool txtBuscarPorENABLE
        {
            get { return txtBuscarPor.Enabled; }
            set { txtBuscarPor.Enabled = value; }
        }

        //*** cmbProcurarEm
        public string cmbProcurarEmTEXT
        {
            get { return cmbProcurarEm.Text; }
            set { cmbProcurarEm.Text = value; }
        }

        public bool cmbProcurarEmENABLE
        {
            get { return cmbProcurarEm.Enabled; }
            set { cmbProcurarEm.Enabled = value; }
        }

        //*** dgvRegistros ***
        //*** DataSource ***
        public DataTable dgvRegistrosDATASOURCE
        {
            set { dgvRegistros.DataSource = value; }
        }
        #region Produto Código
        //*** produto_codigo ***
        public string dgvRegistros_produto_codigo_HEADERTEXT
        {
            get { return dgvRegistros.Columns["produto_codigo"].HeaderText; }
            set { dgvRegistros.Columns["produto_codigo"].HeaderText = value; }
        }

        public int dgvRegistros_produto_codigo_WIDTH
        {
            get { return dgvRegistros.Columns["produto_codigo"].Width; }
            set { dgvRegistros.Columns["produto_codigo"].Width = value; }
        }

        public string dgvRegistros_produto_codigo_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[0].Value.ToString(); }
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
            get { return dgvRegistros.CurrentRow.Cells[1].Value.ToString(); }
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
            get { return dgvRegistros.CurrentRow.Cells[2].Value.ToString(); }
        }
        #endregion
        #region Produto Valor Unitário
        //*** Produto_Valor_Unitario
        public string dgvRegistros_produto_valor_unitario_HEADERTEXT
        {
            get { return dgvRegistros.Columns["produto_valor_unitario"].HeaderText; }
            set { dgvRegistros.Columns["produto_valor_unitario"].HeaderText = value; }
        }

        public int dgvRegistros_produto_valor_unitario_WIDTH
        {
            get { return dgvRegistros.Columns["produto_valor_unitario"].Width; }
            set { dgvRegistros.Columns["produto_valor_unitario"].Width = value; }
        }

        public string dgvRegistros_produto_valor_unitario_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[3].Value.ToString(); }
        }
        #endregion
        #region Produto_Descrição
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
        
        

       
        
              
        
        

        //*****************************************
        //*** Métodos dos Objetos do Formulário ***
        //*****************************************

        #region Declaração de FOCUS
        //*** txtProduto_Codigo ***
        public void txtProduto_CodigoFOCUS()
        {
            this.txtProduto_Codigo.Focus();
        }
        
        //*** txtProduto_Nome ***
        public void txtProduto_NomeFOCUS()
        {
            this.txtProduto_Nome.Focus();
        }

        //*** txtProduto_Tamanho ***
        public void txtProduto_TamanhoFOCUS()
        {
            this.txtProduto_Tamanho.Focus();
        }

        //*** txtProduto_Valor_Unitario ***
        public void txtProduto_Valor_UnitarioFOCUS()
        {
            this.txtProduto_Valor_Unitario.Focus();
        }

        //*** txtProduto_Descricao ***
        public void txtProduto_DescricaoFOCUS()
        {
            this.txtProduto_Descricao.Focus();
        }


        //*** txtBuscarPor ***
        public void txtBuscarPorFOCUS()
        {
            this.txtBuscarPor.Focus();
        }
        #endregion
        //*****************************
        //*** Métodos do Formulário ***
        //*****************************
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void txtProduto_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtProduto_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtProduto_Tamanho_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtProduto_Valor_Unitario_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtProduto_Descricao_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtBuscarPor_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void cmbProcurarEm_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //*** Fecha apenas este Formulário
            //*** Tira o Formulário da Memória ***
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //*** Realiza a Busca na Tabela de Clientes
            //*** e Mostra o resultado no Grid ***
            dgvRegistros.DataSource = objProdutos.CarregarGrid(txtBuscarPor.Text, cmbProcurarEm.Text);
            objProdutos.FormataGrid(this);
            objProdutos.LimpaCampos(this);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            objProdutos.LimpaCampos(this);

           
            

            //*** Ativa os Campos da Tela para digitação ***
            txtProduto_Codigo.Enabled = true;
            txtProduto_Nome.Enabled = true;
            txtProduto_Tamanho.Enabled = true;
            txtProduto_Valor_Unitario.Enabled = true;
            txtProduto_Descricao.Enabled = true;

            //*** Direciona o Cursor para a Caixa de Texto ***
            txtProduto_Codigo.Focus();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //*** Processa o Método de Gravação Identificando se é uma 
            //*** Inclusão ou Alteração
            objProdutos.EfetuaGravacao(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //*** Processa o Método de Exclusão de Registros ***
            objProdutos.EfetuaExclusao(this);
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //*** Carrega os Campos da Linha que foi Clicada no Grid ***
            objProdutos.CarregarCamposGrid(this);
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
             //*** Prepara a Busca Inicial no Grid ***
            dgvRegistros.DataSource = objProdutos.CarregarGrid(txtBuscarPor.Text, cmbProcurarEm.Text);
            objProdutos.FormataGrid(this);

            //*** Desativa o Campo para Digitação ***
            txtProduto_Codigo.Enabled = false;
            txtProduto_Nome.Enabled = false;
            txtProduto_Tamanho.Enabled = false;
            txtProduto_Valor_Unitario.Enabled = false;
            txtProduto_Descricao.Enabled = false;
           

            //*** Coloca o Procurar em com o Primeiro da Lista
            cmbProcurarEm.SelectedIndex = 0;

        }
        
        //*** Referência Botão Ajuda
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Referência no Manual Pac Pizzas" + Convert.ToChar(13) + Convert.ToChar(10) +
                "Pagina: ");
        }
    }
}
