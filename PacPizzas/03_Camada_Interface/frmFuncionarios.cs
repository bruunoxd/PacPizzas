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
using Funcionarios; // Esta é a Classe do Formulário de Funcionarios.

namespace PacPizzas
{
    public partial class frmFuncionarios : Form
    {
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsFuncionarios objFuncionarios = new clsFuncionarios();

        //*** Declara as Propriedades e Métodos do TexBox que 
        //*** serão utilizados pela Classe do Formulário ***
        //**********************************************
        //*** Propriedades dos Objetos do Formulário ***
        //**********************************************
        
       
        //*** txtFuncionario_CPF ***
        public string txtFuncionario_CPFTEXT
        {
            get { return txtFuncionario_CPF.Text; }
            set { txtFuncionario_CPF.Text = value; }
        }

        public bool txtFuncionario_CPFENABLE
        {
            get { return txtFuncionario_CPF.Enabled; }
            set { txtFuncionario_CPF.Enabled = value; }
        }
        
         //*** txtFuncionario_Nome ***
        public string txtFuncionario_NomeTEXT
        {
            get { return txtFuncionario_Nome.Text; }
            set { txtFuncionario_Nome.Text = value; }
        }

        public bool txtFuncionario_NomeENABLE
        {
            get { return txtFuncionario_Nome.Enabled; }
            set { txtFuncionario_Nome.Enabled = value; }
        }

        //*** txtFuncionario_Sobrenome ***
        public string txtFuncionario_SobrenomeTEXT
        {
            get { return txtFuncionario_Sobrenome.Text; }
            set { txtFuncionario_Sobrenome.Text = value; }
        }

        public bool txtFuncionario_SobrenomeENABLE
        {
            get { return txtFuncionario_Sobrenome.Enabled; }
            set { txtFuncionario_Sobrenome.Enabled = value; }
        }

        
        //*** txtFuncionario_RG ***
        public string txtFuncionario_RGTEXT
        {
            get { return txtFuncionario_RG.Text; }
            set { txtFuncionario_RG.Text = value; }
        }

        public bool txtFuncionario_RGENABLE
        {
            get { return txtFuncionario_RG.Enabled; }
            set { txtFuncionario_RG.Enabled = value; }
        }
        
         //*** txtFuncionario_Logradouro ***
        public string txtFuncionario_LogradouroTEXT
        {
            get { return txtFuncionario_Logradouro.Text; }
            set { txtFuncionario_Logradouro.Text = value; }
        }

        public bool txtFuncionario_LogradouroENABLE
        {
            get { return txtFuncionario_Logradouro.Enabled; }
            set { txtFuncionario_Logradouro.Enabled = value; }
        }
        
        //*** Funcionario_Numero_Residencia ***
        public string txtFuncionario_Numero_ResidenciaTEXT
        {
            get { return txtFuncionario_Numero_Residencia.Text; }
            set { txtFuncionario_Numero_Residencia.Text = value; }
        }

        public bool txtFuncionario_Numero_ResidenciaENABLE
        {
            get { return txtFuncionario_Numero_Residencia.Enabled; }
            set { txtFuncionario_Numero_Residencia.Enabled = value; }
        }

         //*** txtFuncionario_Cidade ***
        public string txtFuncionario_CidadeTEXT
        {
            get { return txtFuncionario_Cidade.Text; }
            set { txtFuncionario_Cidade.Text = value; }
        }

        public bool txtFuncionario_CidadeENABLE
        {
            get { return txtFuncionario_Cidade.Enabled; }
            set { txtFuncionario_Cidade.Enabled = value; }
        }

         //*** txtFuncionario_Bairro ***
        public string txtFuncionario_BairroTEXT
        {
            get { return txtFuncionario_Bairro.Text; }
            set { txtFuncionario_Bairro.Text = value; }
        }

        public bool txtFuncionario_BairroENABLE
        {
            get { return txtFuncionario_Bairro.Enabled; }
            set { txtFuncionario_Bairro.Enabled = value; }
        }

       //*** txtFuncionario_CEP ***
        public string txtFuncionario_CEPTEXT
        {
            get { return txtFuncionario_CEP.Text; }
            set { txtFuncionario_CEP.Text = value; }
        }

        public bool txtFuncionario_CEPENABLE
        {
            get { return txtFuncionario_CEP.Enabled; }
            set { txtFuncionario_CEP.Enabled = value; }
        }

         //*** cmbFuncionario_Estado ***
        public string cmbFuncionario_EstadoTEXT
        {
            get { return cmbFuncionario_Estado.Text; }
            set { cmbFuncionario_Estado.Text = value; }
        }

        public bool cmbFuncionario_EstadoENABLE
        {
            get { return cmbFuncionario_Estado.Enabled; }
            set { cmbFuncionario_Estado.Enabled = value; }
        }
        
        //*** txtFuncionario_Telefone ***
        public string txtFuncionario_TelefoneTEXT
        {
            get { return txtFuncionario_Telefone.Text; }
            set { txtFuncionario_Telefone.Text = value; }
        }

        public bool txtFuncionario_TelefoneENABLE
        {
            get { return txtFuncionario_Telefone.Enabled; }
            set { txtFuncionario_Telefone.Enabled = value; }
        }
       
        //*** txtFuncionario_Celular ***
        public string txtFuncionario_CelularTEXT
        {
            get { return txtFuncionario_Celular.Text; }
            set { txtFuncionario_Celular.Text = value; }
        }

        public bool txtFuncionario_CelularENABLE
        {
            get { return txtFuncionario_Celular.Enabled; }
            set { txtFuncionario_Celular.Enabled = value; }
        }
        
        //*** txtFuncionario_Funcao ***
        public string txtFuncionario_FuncaoTEXT
        {
            get { return txtFuncionario_Funcao.Text; }
            set { txtFuncionario_Funcao.Text = value; }
        }

        public bool txtFuncionario_FuncaoENABLE
        {
            get { return txtFuncionario_Funcao.Enabled; }
            set { txtFuncionario_Funcao.Enabled = value; }
        }
        
         //*** txtFuncionario_Salario ***
        public string txtFuncionario_SalarioTEXT
        {
            get { return txtFuncionario_Salario.Text; }
            set { txtFuncionario_Salario.Text = value; }
        }

        public bool txtFuncionario_SalarioENABLE
        {
            get { return txtFuncionario_Salario.Enabled; }
            set { txtFuncionario_Salario.Enabled = value; }
        }
        
        //*** txtFuncionario_Admissao ***
        public string txtFuncionario_AdmissaoTEXT
        {
            get { return txtFuncionario_Admissao.Text; }
            set { txtFuncionario_Admissao.Text = value; }
        }

        public bool txtFuncionario_AdmissaoENABLE
        {
            get { return txtFuncionario_Admissao.Enabled; }
            set { txtFuncionario_Admissao.Enabled = value; }
        }

        //*** txtFuncionario_Demissao ***
        public string txtFuncionario_DemissaoTEXT
        {
            get { return txtFuncionario_Demissao.Text; }
            set { txtFuncionario_Demissao.Text = value; }
        }

        public bool txtFuncionario_DemissaoENABLE
        {
            get { return txtFuncionario_Demissao.Enabled; }
            set { txtFuncionario_Demissao.Enabled = value; }
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
        #region Funcionario CPF
        //*** funcionario_cpf ***
        public string dgvRegistros_funcionario_cpf_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_cpf"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_cpf"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_cpf_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_cpf"].Width; }
            set { dgvRegistros.Columns["funcionario_cpf"].Width = value; }
        }

        public string dgvRegistros_funcionario_cpf_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[0].Value.ToString(); }
        }
        #endregion
        #region Funcionario Nome
        //*** funcionario_nome
        public string dgvRegistros_funcionario_nome_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_nome"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_nome"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_nome_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_nome"].Width; }
            set { dgvRegistros.Columns["funcionario_nome"].Width = value; }
        }

        public string dgvRegistros_funcionario_nome_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[1].Value.ToString(); }
        }
        #endregion
        #region Funcionario Sobrenome
        //*** funcionario_sobrenome
        public string dgvRegistros_funcionario_sobrenome_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_sobrenome"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_sobrenome"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_sobrenome_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_sobrenome"].Width; }
            set { dgvRegistros.Columns["funcionario_sobrenome"].Width = value; }
        }

        public string dgvRegistros_funcionario_sobrenome_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[2].Value.ToString(); }
        }
        #endregion
        #region Funcionario RG
        //*** funcionario_rg
        public string dgvRegistros_funcionario_rg_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_rg"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_rg"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_rg_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_rg"].Width; }
            set { dgvRegistros.Columns["funcionario_rg"].Width = value; }
        }

        public string dgvRegistros_funcionario_rg_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[3].Value.ToString(); }
        }
        #endregion
        #region Funcionario Logradouro
        //*** funcionario_logradouro
        public string dgvRegistros_funcionario_logradouro_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_logradouro"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_logradouro"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_logradouro_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_logradouro"].Width; }
            set { dgvRegistros.Columns["funcionario_logradouro"].Width = value; }
        }

        public string dgvRegistros_funcionario_logradouro_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[4].Value.ToString(); }
        }
        #endregion
        #region Funcionario Numero Residência
        //*** funcionario_numero_residencia
        public string dgvRegistros_funcionario_numero_residencia_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_numero_residencia"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_numero_residencia"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_numero_residencia_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_numero_residencia"].Width; }
            set { dgvRegistros.Columns["funcionario_numero_residencia"].Width = value; }
        }

        public string dgvRegistros_funcionario_numero_residencia_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[5].Value.ToString(); }
        }
        #endregion
        #region Funcionario Cidade

        //*** funcionario_cidade
        public string dgvRegistros_funcionario_cidade_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_cidade"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_cidade"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_cidade_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_cidade"].Width; }
            set { dgvRegistros.Columns["funcionario_cidade"].Width = value; }
        }

        public string dgvRegistros_funcionario_cidade_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[6].Value.ToString(); }
        }
        #endregion
        #region Funcionario Bairro
        //*** funcionario_bairro
        public string dgvRegistros_funcionario_bairro_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_bairro"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_bairro"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_bairro_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_bairro"].Width; }
            set { dgvRegistros.Columns["funcionario_bairro"].Width = value; }
        }

        public string dgvRegistros_funcionario_bairro_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[7].Value.ToString(); }
        }
        #endregion
        #region Funcionario CEP
        //*** funcionario_cep
        public string dgvRegistros_funcionario_cep_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_cep"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_cep"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_cep_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_cep"].Width; }
            set { dgvRegistros.Columns["funcionario_cep"].Width = value; }
        }

        public string dgvRegistros_funcionario_cep_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[8].Value.ToString(); }
        }
        #endregion
        #region Funcionario Estado
        //*** funcionario_estado
        public string dgvRegistros_funcionario_estado_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_estado"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_estado"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_estado_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_estado"].Width; }
            set { dgvRegistros.Columns["funcionario_estado"].Width = value; }
        }

        public string dgvRegistros_funcionario_estado_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[9].Value.ToString(); }
        }
        #endregion
        #region Funcionario Telefone Fixo
        //*** funcionario_telefone
        public string dgvRegistros_funcionario_telefone_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_telefone"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_telefone"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_telefone_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_telefone"].Width; }
            set { dgvRegistros.Columns["funcionario_telefone"].Width = value; }
        }

        public string dgvRegistros_funcionario_telefone_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[10].Value.ToString(); }
        }
        #endregion
        #region Funcionario Telefone Celular
        //*** funcionario_celular
        public string dgvRegistros_funcionario_celular_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_celular"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_celular"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_celular_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_celular"].Width; }
            set { dgvRegistros.Columns["funcionario_celular"].Width = value; }
        }

        public string dgvRegistros_funcionario_celular_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[11].Value.ToString(); }
        }
        #endregion
        #region Funcionario Função
        //*** funcionario_funcao
        public string dgvRegistros_funcionario_funcao_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_funcao"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_funcao"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_funcao_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_funcao"].Width; }
            set { dgvRegistros.Columns["funcionario_funcao"].Width = value; }
        }

        public string dgvRegistros_funcionario_funcao_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[12].Value.ToString(); }
        }
        #endregion
        #region Funcionario Salario
        //*** funcionario_salario
        public string dgvRegistros_funcionario_salario_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_salario"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_salario"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_salario_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_salario"].Width; }
            set { dgvRegistros.Columns["funcionario_salario"].Width = value; }
        }

        public string dgvRegistros_funcionario_salario_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[13].Value.ToString(); }
        }
        #endregion
        #region Funcionario Data de Admissão
        //*** funcionario_admissao
        public string dgvRegistros_funcionario_admissao_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_admissao"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_admissao"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_admissao_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_admissao"].Width; }
            set { dgvRegistros.Columns["funcionario_admissao"].Width = value; }
        }

        public string dgvRegistros_funcionario_admissao_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[14].Value.ToString(); }
        }
        #endregion
        #region Funcionario Data de Demissão
        //*** funcionario_demissao
        public string dgvRegistros_funcionario_demissao_HEADERTEXT
        {
            get { return dgvRegistros.Columns["funcionario_demissao"].HeaderText; }
            set { dgvRegistros.Columns["funcionario_demissao"].HeaderText = value; }
        }

        public int dgvRegistros_funcionario_demissao_WIDTH
        {
            get { return dgvRegistros.Columns["funcionario_demissao"].Width; }
            set { dgvRegistros.Columns["funcionario_demissao"].Width = value; }
        }

        public string dgvRegistros_funcionario_demissao_GRIDCLICK
        {
            get { return dgvRegistros.CurrentRow.Cells[15].Value.ToString(); }
        }
        #endregion




        //*****************************************
        //*** Métodos dos Objetos do Formulário ***
        //*****************************************

        #region Declaração de FOCUS
        //*** txtFuncionario_CPF ***
        public void txtFuncionario_CPFFOCUS()
        {
            this.txtFuncionario_CPF.Focus();
        }

        //*** txtFuncionario_Nome ***
        public void txtFuncionario_NomeFOCUS()
        {
            this.txtFuncionario_Nome.Focus();
        }
        
        //*** txtFuncionario_Sobrenome ***
        public void txtFuncionario_SobrenomeFOCUS()
        {
            this.txtFuncionario_Sobrenome.Focus();
        }

        //*** txtFuncionario_RG ***
        public void txtFuncionario_RGFOCUS()
        {
            this.txtFuncionario_RG.Focus();
        }
        
        //*** txtFuncionario_Logradouro ***
        public void txtFuncionario_LogradouroFOCUS()
        {
            this.txtFuncionario_Logradouro.Focus();
        }

        //*** txtFuncionario_Numero_Residencia ***
        public void txtFuncionario_Numero_ResidenciaFOCUS()
        {
            this.txtFuncionario_Numero_Residencia.Focus();
        }

        //*** txtFuncionario_Cidade ***
        public void txtFuncionario_CidadeFOCUS()
        {
            this.txtFuncionario_Cidade.Focus();
        }

        //*** txtFuncionario_Bairro ***
        public void txtFuncionario_BairroFOCUS()
        {
            this.txtFuncionario_Bairro.Focus();
        }

        //*** txtFuncionario_CEP ***
        public void txtFuncionario_CEPFOCUS()
        {
            this.txtFuncionario_CEP.Focus();
        }

        //*** txtFuncionario_Telefone ***
        public void txtFuncionario_TelefoneFOCUS()
        {
            this.txtFuncionario_Telefone.Focus();
        }

        //*** txtFuncionario_Celular ***
        public void txtFuncionario_CelularFOCUS()
        {
            this.txtFuncionario_Celular.Focus();
        }

        //*** txtFuncionario_Funcao ***
        public void txtFuncionario_FuncaoFOCUS()
        {
            this.txtFuncionario_Funcao.Focus();
        }

        //*** txtFuncionario_Salario ***
        public void txtFuncionario_SalarioFOCUS()
        {
            this.txtFuncionario_Salario.Focus();
        }
        
        //*** txtFuncionario_Admissao ***
        public void txtFuncionario_AdmissaoFOCUS()
        {
            this.txtFuncionario_Admissao.Focus();
        }

        //*** txtFuncionario_Demissao ***
        public void txtFuncionario_DemissaoFOCUS()
        {
            this.txtFuncionario_Demissao.Focus();
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
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void txtFuncionario_CPF_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Nome_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Sobrenome_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_RG_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Logradouro_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Numero_Residencia_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Cidade_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Bairro_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_CEP_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void cmbFuncionario_Estado_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Telefone_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Celular_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Funcao_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Salario_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }
        
        private void txtFuncionario_Admissao_KeyDown(object sender, KeyEventArgs e)
        {
        clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtFuncionario_Demissao_KeyDown(object sender, KeyEventArgs e)
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
            //*** Realiza a Busca na Tabela de Funcionarios
            //*** e Mostra o resultado no Grid ***
            dgvRegistros.DataSource = objFuncionarios.CarregarGrid(txtBuscarPor.Text, cmbProcurarEm.Text);
            objFuncionarios.FormataGrid(this);
            objFuncionarios.LimpaCampos(this);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            objFuncionarios.LimpaCampos(this);

            //*** Desativa o Campo Sequencial da Tela ***
            

            //*** Ativa os Campos da Tela para digitação ***
            txtFuncionario_CPF.Enabled = true;
            txtFuncionario_Nome.Enabled = true;
            txtFuncionario_Sobrenome.Enabled = true;
            txtFuncionario_RG.Enabled = true;
            txtFuncionario_Logradouro.Enabled = true;
            txtFuncionario_Numero_Residencia.Enabled = true;
            txtFuncionario_Cidade.Enabled = true;
            txtFuncionario_Bairro.Enabled = true;
            txtFuncionario_CEP.Enabled = true;
            cmbFuncionario_Estado.Enabled = true;
            txtFuncionario_Telefone.Enabled = true;
            txtFuncionario_Celular.Enabled = true;
            txtFuncionario_Funcao.Enabled = true;
            txtFuncionario_Salario.Enabled = true;
            txtFuncionario_Admissao.Enabled = true;
            txtFuncionario_Demissao.Enabled = true;
            
            //*** Direciona o Cursor para a Caixa de Texto ***
            txtFuncionario_CPF.Focus();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //*** Processa o Método de Gravação Identificando se é uma 
            //*** Inclusão ou Alteração
            objFuncionarios.EfetuaGravacao(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //*** Processa o Método de Exclusão de Registros ***
            objFuncionarios.EfetuaExclusao(this);
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //*** Carrega os Campos da Linha que foi Clicada no Grid ***
            objFuncionarios.CarregarCamposGrid(this);
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            //*** Traz o Combo Box com um item selecionado ***
            cmbProcurarEm.SelectedIndex = 0;
            cmbFuncionario_Estado.SelectedIndex = cmbFuncionario_Estado.FindStringExact("SP");


            //*** Prepara a Busca Inicial no Grid ***
            dgvRegistros.DataSource = objFuncionarios.CarregarGrid(txtBuscarPor.Text, cmbProcurarEm.Text);
            objFuncionarios.FormataGrid(this);

            //*** Desativa o Campo para Digitação ***
            txtFuncionario_CPF.Enabled = false;
            txtFuncionario_Nome.Enabled = false;
            txtFuncionario_Sobrenome.Enabled = false;
            txtFuncionario_RG.Enabled = false;
            txtFuncionario_Logradouro.Enabled = false;
            txtFuncionario_Numero_Residencia.Enabled = false;
            txtFuncionario_Cidade.Enabled = false;
            txtFuncionario_Bairro.Enabled = false;
            txtFuncionario_CEP.Enabled = false;
            cmbFuncionario_Estado.Enabled = false;
            txtFuncionario_Telefone.Enabled = false;
            txtFuncionario_Celular.Enabled = false;
            txtFuncionario_Funcao.Enabled = false;
            txtFuncionario_Salario.Enabled = false;
            txtFuncionario_Admissao.Enabled = false;
            txtFuncionario_Demissao.Enabled = false;
        }
        
        //*** Referência Botão Ajuda
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Referência no Manual Pac Pizzas" + Convert.ToChar(13) + Convert.ToChar(10) +
                "Pagina: ");
        }
    }
}
