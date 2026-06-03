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
using RotinasGerais; // Este é o Módulo de Visão Global
using ConexaoBanco; // Esta é a Classe de Conexão com o Banco de Dados
using Usuarios; // Esta é a Classe do Formulário de Usuários

namespace PacPizzas
{
    public partial class frmUsuarios : Form
    {
        //*** Instancia os Objetos da Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsUsuarios objUsuarios = new clsUsuarios();

        //*** Declara as Propriedades e Métodos do TexBox que 
        //*** serão utilizados pela Classe do Formulário 
        //**********************************************
        //*** Propriedades dos Objetos do Formulário ***
        //**********************************************
        //*** txtUsuario_Login ***

        public string txtUsuario_LoginTEXT
        {
            get { return txtUsuario_Login.Text; }
            set { txtUsuario_Login.Text = value; }
        }

        public bool txtUsuario_LoginENABLE
        {
            get { return txtUsuario_Login.Enabled; }
            set { txtUsuario_Login.Enabled = value; }
        }

        //*** txtUsuario_Senha ***
        public string txtUsuario_SenhaTEXT
        {
            get { return txtUsuario_Senha.Text; }
            set { txtUsuario_Senha.Text = value; }
        }

        public bool txtUsuario_SenhaENABLE
        {
            get { return txtUsuario_Senha.Enabled; }
            set { txtUsuario_Senha.Enabled = value; }
        }

        //*** cmbUsuarioCPF ***
        public string cmbUsuarioCPFTEXT
        {
            get { return cmbUsuarioCPF.Text; }
            set { cmbUsuarioCPF.Text = value; }
        }

        public bool cmbUsuarioCPFENABLE
        {
            get { return cmbUsuarioCPF.Enabled; }
            set { cmbUsuarioCPF.Enabled = value; }
        }


        public DataTable cmbUsuarioCPFDATASOURCE
        {
            set { cmbUsuarioCPF.DataSource = value; }
        }

        public string cmbUsuarioCPFDISPLAYMEMBER
        {
            set { cmbUsuarioCPF.DisplayMember = value; }
        }

        public string cmbUsuarioCPFVALUEMEMBER
        {
            set { cmbUsuarioCPF.ValueMember = value; }
        }

        public void cmbUsuarioCPFLOCALIZA(string cpfRecebido)
        {
            cmbUsuarioCPF.SelectedIndex = cmbUsuarioCPF.FindString(cpfRecebido);
        }

        //*** txtBuscarPor ***
        public string txtBuscarPorTEXT
        {
            get { return txtBuscarPor.Text; }
            set { txtBuscarPor.Text = value; }
        }

        //*** cmbProcurarEm ***
        public string cmbProcurarEmTEXT
        {
            get { return cmbProcurarEm.Text; }
            set { cmbProcurarEm.Text = value; }
        }

        //*** dvgRegistros ***
        //*** DataSource ***
        public DataTable dgvRegistrosDATASOURCE
        {
            set { dgvRegistros.DataSource = value; }
        }

        //*** usuario_login HEADER TEXT ***
        public string dgvRegistros_Login_HEADERTEX
        {
            get { return dgvRegistros.Columns["usuario_login"].HeaderText; }
            set { dgvRegistros.Columns["usuario_login"].HeaderText = value; }
        }

        public int dgvRegistros_Login_WIDTH
        {
            get { return dgvRegistros.Columns["usuario_login"].Width; }
            set { dgvRegistros.Columns["usuario_login"].Width = value; }
        }

        public string dgvRegistros_usuario_login_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[0].Value.ToString(); }
        }

        //*** usuario_senha HEADER TEXT ***
        public string dgvRegistros_Senha_HEADERTEX
        {
            get { return dgvRegistros.Columns["usuario_senha"].HeaderText; }
            set { dgvRegistros.Columns["usuario_senha"].HeaderText = value; }
        }

        public int dgvRegistros_Senha_WIDTH
        {
            get { return dgvRegistros.Columns["usuario_senha"].Width; }
            set { dgvRegistros.Columns["usuario_senha"].Width = value; }
        }

        public bool dgvRegistros_Senha_VISIBLE
        {
            set { dgvRegistros.Columns["usuario_senha"].Visible = value; }
        }

        public string dgvRegistros_usuario_senha_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[1].Value.ToString(); }
        }

        //*** usuario_funcionario_cpf ***
        public string dgvRegistros_usuario_funcionario_cpf_HEADERTEXT
        {
            get { return dgvRegistros.Columns["usuario_funcionario_cpf"].HeaderText; }
            set { dgvRegistros.Columns["usuario_funcionario_cpf"].HeaderText = value; }
        }

        public int dgvRegistros_usuario_funcionario_cpf_WIDTH
        {
            get { return dgvRegistros.Columns["usuario_funcionario_cpf"].Width; }
            set { dgvRegistros.Columns["usuario_funcionario_cpf"].Width = value; }
        }

        public string dgvRegistros_usuario_funcionario_cpf_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[2].Value.ToString(); }
        }
        //*** Declara os Eventos (Método) que serão vistos
        //*** pela Classe "clsUsuarios" ***
        public void txtUsuario_LoginFOCUS()
        {
            txtUsuario_Login.Focus();
        }

        public void txtUsuario_SenhaFOCUS()
        {
            txtUsuario_Senha.Focus();
        }

        public void cmbUsuarioCPFFOCUS()
        {
            cmbUsuarioCPF.Focus();
        }
        
        
        
        public void txtBuscarPor_FOCUS()
        {
            txtBuscarPor.Focus();
        }

        //*****************************************
        //*** Métodos dos Objetos do Formulário ***
        //*****************************************
        public frmUsuarios()
        {
            InitializeComponent();
        }
        //
        private void txtUsuario_Login_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtUsuario_Senha_KeyDown(object sender, KeyEventArgs e)
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

        private void cmbUsuarioCPF_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //*** Realiza a Busca na Tabela de Usuarios e Mostra o 
            //*** resultado no Grid ***
            dgvRegistros.DataSource = objUsuarios.CarregarGrid(txtBuscarPor.Text, cmbProcurarEm.Text);
            objUsuarios.FormataGrid(this);
            objUsuarios.LimpaCampos(this);
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //*** Carrega os Campos da Linha que foi Clicada no Grid ***
            objUsuarios.CarregaCamposGrid(this);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            //*** Traz o Combo Box com um item selecionado ***
            cmbProcurarEm.SelectedIndex = 0;

            //*** Prepara a Busca Inicial do Grid ***
            dgvRegistros.DataSource = objUsuarios.CarregarGrid(txtBuscarPor.Text, cmbProcurarEm.Text);
            objUsuarios.FormataGrid(this);

            //*** Desativa o Campo para Digitação ***
            txtUsuario_Login.Enabled = false;
            txtUsuario_Senha.Enabled = false;
            cmbUsuarioCPF.Enabled = false;
            
            //*** Carrega os Funcionarios da Tabela no ComboBox correspondente ***
            objUsuarios.CarregaComboFuncionarios(this);
            //cmbUsuarioCPF.SelectedIndex = 1;
            cmbUsuarioCPF.SelectedIndex = cmbUsuarioCPF.FindStringExact("");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            objUsuarios.LimpaCampos(this);

            //*** Ativar os Campos da Tela para digitação ***
            txtUsuario_Login.Enabled = true;
            txtUsuario_Senha.Enabled = true;
            cmbUsuarioCPF.Enabled = true;
            txtUsuario_Login.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //*** Processa o Método de Gravação Identificando se 
            //*** é uma Inclusão ou Alteração ***
            objUsuarios.EfetuaGravacao(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //*** Processa o Método de Exclusão de Registros ***
            objUsuarios.EfetuaExclusao(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //*** Fecha apenas este Formulário. Tira o Formulário
            //*** da Memória. ***
            this.Close();
        }
        
        //*** Referência Botão Ajuda
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Referência no Manual Pac Pizzas" + Convert.ToChar(13) + Convert.ToChar(10) +
                "Pagina: ");
        }

    }
}
