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
using Login; // Esta é a classe do Formulário de Login.

namespace PacPizzas
{
    public partial class frmLogin : Form
    {

        //*** Instancia os Objetos das Classes Correspondente ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsLogin objLogin = new clsLogin();

        //*** Declara as Propriedades e Metódos do TextBox
        //*** que serão utilizados pela classe do Formulário
        //*******************************
        //***Propriedades dos TextBox ***
        //*******************************
        public string txtLoginTEXT
        {
            get { return txtLogin.Text; }
            set { txtLogin.Text = value; }
        }

        public string txtSenhaTEXT
        {
            get { return txtSenha.Text; }
            set { txtSenha.Text = value; }
        }

        //***************************
        //*** Métodos dos TextBox ***
        //***************************
        public void txtLoginFOCUS()
        {
            this.txtLogin.Focus(); // Manda o Focus para a Caixa
                                   // de Texto desejada. 
        }

        public void txtSenhaFOCUS()
        {
            this.txtSenha.Focus();// Manda o Focus para a Caixa
                                  // de Texto desejada.
        }

        //*****************************
        //*** Métodos do Formulário ***
        //*****************************
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //*** Encerra a Aplicação ***
            Application.Exit();
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsRotinasGerais.TentativasLogin = 0;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //*** Executa o Método para efetuar o login ***
            objLogin.EfetuaLogin(this);
        }

        
    }
}
