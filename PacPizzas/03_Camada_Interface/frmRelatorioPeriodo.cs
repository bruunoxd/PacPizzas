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
using RelatorioPeriodo; // Esta é a classe do Formulário de Relatório Periodo.

namespace PacPizzas
{
    public partial class frmRelatorioPeriodo : Form
    {
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsRelatorioPeriodo objRelatorioPeriodo = new clsRelatorioPeriodo();

        //*** Declara as Propriedades e Métodos do TextBox que Serão
        //*** utilizados pela classe do Formulário ***
        //**********************************************
        //*** Propriedades dos Objetos do Formulário ***
        //**********************************************
        //*** txtDataInicio ***
        public string txtDataInicioTEXT
        {
            get { return txtDataInicio.Text; }
            set { txtDataInicio.Text = value; }
        }

        //*** txtDataFinal ***
        public string txtDataFinalTEXT
        {
            get { return txtDataFinal.Text; }
            set { txtDataFinal.Text = value; }
        }
        
        //*****************************************
        //*** Métodos dos Objetos do Formulário ***
        //*****************************************

        public void txtDataInicioFOCUS()
        {
            this.txtDataInicio.Focus();
        }

        public void txtDataFinalFOCUS()
        {
            this.txtDataFinal.Focus();
        }

        //*****************************
        //*** Métodos do Formulário ***
        //*****************************
        public frmRelatorioPeriodo()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //*** Transforma a Seta do Cursor em Espera  ***
            this.Cursor = Cursors.WaitCursor;

            //*** Executa o Método para Gerar o Relatório ***
            objRelatorioPeriodo.GerarRelatorio(this);

            //*** Volta a Seta do Cursor ao Normal ***
            this.Cursor = Cursors.Arrow;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //*** Fecha apenas este formulário sem encerrar a aplicação ***
            this.Close();
        }

        private void frmRelatorioPeriodo_Load(object sender, EventArgs e)
        {
            //*** Preenche a Data Atual para os TextBox de Período de Datas.   ***
            //*** A "@" permitirá a Formatação da Data para o Padrão Desejado. ***
            txtDataInicio.Text = DateTime.Now.ToString(@"dd/MM/yyyy");
            txtDataFinal.Text = DateTime.Now.ToString(@"dd/MM/yyyy");
        }

        private void txtDataInicio_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }

        private void txtDataFinal_KeyDown(object sender, KeyEventArgs e)
        {
            clsRotinasGerais.PulaCampoEnter(e.KeyValue);
        }
    }
}
