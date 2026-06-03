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
using Clientes; // Esta é a Classe do Formulário de Clientes.

namespace PacPizzas
{
    public partial class frmClientes : Form
    {
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsClientes objClientes = new clsClientes();

        //*** Declara as Propriedades e Métodos do TexBox que 
        //*** serão utilizados pela Classe do Formulário ***
        //**********************************************
        //*** Propriedades dos Objetos do Formulário ***
        //**********************************************
        //*** txtCliente_Sequencial ***
        public string txtCliente_SequencialTEXT
        {
            get { return txtCliente_Sequencial.Text; }
            set { txtCliente_Sequencial.Text = value; }
        }

        public bool txtCliente_SequencialENABLE
        {
            get { return txtCliente_Sequencial.Enabled; }
            set { txtCliente_Sequencial.Enabled = value; }
        }

        //*** txtCliente_Nome ***
        public string txtCliente_NomeTEXT
        {
            get { return txtCliente_Nome.Text; }
            set { txtCliente_Nome.Text = value; }
        }

        public bool txtCliente_NomeENABLE
        {
            get { return txtCliente_Nome.Enabled; }
            set { txtCliente_Nome.Enabled = value; }
        }
        
        //*** txtCliente_CPF ***
        public string txtCliente_CPFTEXT
        {
            get { return txtCliente_CPF.Text; }
            set { txtCliente_CPF.Text = value; }
        }

        public bool txtCliente_CPFENABLE
        {
            get { return txtCliente_CPF.Enabled; }
            set { txtCliente_CPF.Enabled = value; }
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


        //*** rdbAtivo ***
        public bool rdbAtivoCHECKED
        {
            get { return rdbAtivo.Checked; }
            set { rdbAtivo.Checked = value; }
        }

        public bool rdbAtivoENABLE
        {
            get { return rdbAtivo.Enabled; }
            set { rdbAtivo.Enabled = value; }
        }

        //*** rdbInativo ***
        public bool rdbInativoCHECKED
        {
            get { return rdbInativo.Checked; }
            set { rdbInativo.Checked = value; }
        }

        public bool rdbInativoENABLE
        {
            get { return rdbInativo.Enabled; }
            set { rdbInativo.Enabled = value; }
        }

        //*** txtCliente_Numero_Residencia ***
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

        

        //*** txtCliente_CEP ***
        public string txtCliente_CEPTEXT
        {
            get { return txtCliente_CEP.Text; }
            set { txtCliente_CEP.Text = value; }
        }

        public bool txtCliente_CEPENABLE
        {
            get { return txtCliente_CEP.Enabled; }
            set { txtCliente_CEP.Enabled = value; }
        }

        //*** txtCliente_Telefone ***
        public string txtCliente_TelefoneTEXT
        {
            get { return txtCliente_Telefone.Text; }
            set { txtCliente_Telefone.Text = value; }
        }

        public bool txtCliente_TelefoneENABLE
        {
            get { return txtCliente_Telefone.Enabled; }
            set { txtCliente_Telefone.Enabled = value; }
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
        #region Cliente Sequencial
        //*** cliente_sequencial ***
        public string dgvRegistros_cliente_sequencial_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_sequencial"].HeaderText; }
            set { dgvRegistros.Columns["cliente_sequencial"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_sequencial_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_sequencial"].Width; }
            set { dgvRegistros.Columns["cliente_sequencial"].Width = value; }
        }

        public string dgvRegistros_cliente_sequencial_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[0].Value.ToString(); }
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
            get { return dgvRegistros.CurrentRow.Cells[1].Value.ToString(); }
        }
        #endregion
        #region Cliente cpf
        //*** cliente_cpf
        public string dgvRegistros_cliente_cpf_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_cpf"].HeaderText; }
            set { dgvRegistros.Columns["cliente_cpf"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_cpf_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_cpf"].Width; }
            set { dgvRegistros.Columns["cliente_cpf"].Width = value; }
        }

        public string dgvRegistros_cliente_cpf_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[2].Value.ToString(); }
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
            get { return dgvRegistros.CurrentRow.Cells[3].Value.ToString(); }
        }
        #endregion
        #region Cliente Numero
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
            get { return dgvRegistros.CurrentRow.Cells[4].Value.ToString(); }
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
            get { return dgvRegistros.CurrentRow.Cells[5].Value.ToString(); }
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
            get { return dgvRegistros.CurrentRow.Cells[6].Value.ToString(); }
        }
        #endregion

        #region Cliente Ponto de Referencia

        //*** cliente_bairro
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
            get { return dgvRegistros.CurrentRow.Cells[7].Value.ToString(); }
        }
        #endregion

        #region Cliente CEP
        //*** cliente_cep
        public string dgvRegistros_cliente_cep_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_cep"].HeaderText; }
            set { dgvRegistros.Columns["cliente_cep"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_cep_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_cep"].Width; }
            set { dgvRegistros.Columns["cliente_cep"].Width = value; }
        }

        public string dgvRegistros_cliente_cep_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[8].Value.ToString(); }
        }
        #endregion
        #region Cliente Telefone
        //*** cliente_telefone
        public string dgvRegistros_cliente_telefone_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_telefone"].HeaderText; }
            set { dgvRegistros.Columns["cliente_telefone"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_telefone_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_telefone"].Width; }
            set { dgvRegistros.Columns["cliente_telefone"].Width = value; }
        }

        public string dgvRegistros_cliente_telefone_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[9].Value.ToString(); }
        }
        #endregion
        #region Cliente Status
        //*** cliente_status
        public string dgvRegistros_cliente_status_HEADERTEXT
        {
            get { return dgvRegistros.Columns["cliente_status"].HeaderText; }
            set { dgvRegistros.Columns["cliente_status"].HeaderText = value; }
        }

        public int dgvRegistros_cliente_status_WIDTH
        {
            get { return dgvRegistros.Columns["cliente_status"].Width; }
            set { dgvRegistros.Columns["cliente_status"].Width = value; }
        }

        public string dgvRegistros_cliente_status_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[10].Value.ToString(); }
        }
        #endregion

        //*****************************************
        //*** Métodos dos Objetos do Formulário ***
        //*****************************************

        #region Declaração de FOCUS
        //*** txtCliente_Nome ***
        public void txtCliente_NomeFOCUS()
        {
            this.txtCliente_Nome.Focus();
        }

        //*** txtCliente_CPF ***
        public void txtCliente_CPFFOCUS()
        {
            this.txtCliente_CPF.Focus();
        }

        //*** txtCliente_Logradouro ***
        public void txtCliente_LogradouroFOCUS()
        {
            this.txtCliente_Logradouro.Focus();
        }

        //*** txtCliente_Numero ***
        public void txtCliente_Numero_ResidenciaFOCUS()
        {
            this.txtCliente_Numero_Residencia.Focus();
        }

        //*** txtCliente_Complemento ***
        public void txtCliente_ComplementoFOCUS()
        {
            this.txtCliente_Complemento.Focus();
        }


        //*** txtCliente_Bairro ***
        public void txtCliente_BairroFOCUS()
        {
            this.txtCliente_Bairro.Focus();
        }

        //*** txtCliente_Ponto_Referencia ***
        public void txtCliente_Ponto_ReferenciaFOCUS()
        {
            this.txtCliente_Ponto_Referencia.Focus();
        }

        //*** txtCliente_CEP ***
        public void txtCliente_CEPFOCUS()
        {
            this.txtCliente_CEP.Focus();
        }

        //*** txtCliente_Telefone ***
        public void txtCliente_TelefoneFOCUS()
        {
            this.txtCliente_Telefone.Focus();
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
        public frmClientes()
        {
            InitializeComponent();
        }

        private void txtCliente_Sequencial_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtCliente_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }
        private void txtCliente_CPF_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtCliente_Logradouro_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void cliente_numero_residencia_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void rdbAtivo_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void rdbInativo_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtCliente_Complemento_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtCliente_Bairro_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtCliente_Ponto_Referencia_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }
        
        private void txtCliente_CEP_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtCliente_Telefone_KeyDown(object sender, KeyEventArgs e)
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
            dgvRegistros.DataSource = objClientes.CarregarGrid(txtBuscarPor.Text, cmbProcurarEm.Text);
            objClientes.FormataGrid(this);
            objClientes.LimpaCampos(this);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            objClientes.LimpaCampos(this);

            //*** Desativa o Campo Sequencial da Tela ***
            txtCliente_Sequencial.Enabled = false;

            //*** Ativa os Campos da Tela para digitação ***
            txtCliente_Nome.Enabled = true;
            txtCliente_CPF.Enabled = true;
            txtCliente_Logradouro.Enabled = true;
            txtCliente_Numero_Residencia.Enabled = true;
            txtCliente_Complemento.Enabled = true;
            txtCliente_Bairro.Enabled = true;
            txtCliente_Ponto_Referencia.Enabled = true;
            txtCliente_CEP.Enabled = true;
            txtCliente_Telefone.Enabled = true;
            rdbAtivo.Enabled = true;
            rdbInativo.Enabled = true;

            //*** Direciona o Cursor para a Caixa de Texto ***
            txtCliente_Nome.Focus();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //*** Processa o Método de Gravação Identificando se é uma 
            //*** Inclusão ou Alteração
            objClientes.EfetuaGravacao(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //*** Processa o Método de Exclusão de Registros ***
            objClientes.EfetuaExclusao(this);
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //*** Carrega os Campos da Linha que foi Clicada no Grid ***
            objClientes.CarregarCamposGrid(this);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {


            //*** Prepara a Busca Inicial no Grid ***
            dgvRegistros.DataSource = objClientes.CarregarGrid(txtBuscarPor.Text, cmbProcurarEm.Text);
            objClientes.FormataGrid(this);

            //*** Desativa o Campo para Digitação ***
            txtCliente_Sequencial.Enabled = false;
            txtCliente_Nome.Enabled = false;
            txtCliente_CPF.Enabled = false;
            txtCliente_Logradouro.Enabled = false;
            txtCliente_Numero_Residencia.Enabled = false;
            txtCliente_Complemento.Enabled = false;
            txtCliente_Bairro.Enabled = false;
            txtCliente_Ponto_Referencia.Enabled = false;
            txtCliente_CEP.Enabled = false;
            txtCliente_Telefone.Enabled = false;
            rdbAtivo.Enabled = false;
            rdbInativo.Enabled = false;

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
