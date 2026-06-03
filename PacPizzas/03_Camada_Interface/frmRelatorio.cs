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
using Relatorio; // Esta é a Classe do Formulário de Relatórios.
using Microsoft.Reporting.WinForms; // Esta é a Classe de Relatórios

namespace PacPizzas
{
    public partial class frmRelatorio : Form
    {
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        clsRelatorio objRelatorio = new clsRelatorio();

        //*** Instancia um Objeto do Formulário "frmRelatorioPeriodo"
        //*** sem a Herança *** 
        frmRelatorioPeriodo _frmRelatorioPeriodo;

        //*** Declara as Propriedades e Métodos que serão utilizados
        //*** pela Classe do Formulário ***
        //***
        //*** Evento de Ativação do Relatório ***
        //***

        public void rptPedidosATIVACAO(DataSet ds)
        {

            //*** Prepara o Relatório para o Tipo de Processo e Caminho do Relatório ***
            rptPedidos.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rptPedidos.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\rptPedidos.rdlc";

            //*** Limpa o DataSource para a Geração do Relatório
            rptPedidos.LocalReport.DataSources.Clear();
            rptPedidos.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsPedidos", ds.Tables[0]));
            rptPedidos.DocumentMapCollapsed = true;

            //*** Prepara o envio do Título do Relatório com o Período escolhido ***
            ReportParameter parametro = new ReportParameter();
            parametro = new ReportParameter("TituloRelatorio", "Relatório de Pedidos - Periodo Data de Abertura: " +
            _frmRelatorioPeriodo.txtDataInicioTEXT.Trim() +
            "até" +
            _frmRelatorioPeriodo.txtDataFinalTEXT.Trim());
            rptPedidos.LocalReport.SetParameters(parametro);

            //*** Volta a Seta do Cursor ao Normal ***
            this.Cursor = Cursors.Arrow;

            //*** Exibe o Relatório ***
            this.rptPedidos.RefreshReport();
        }

        //*** Recebe o THIS do Formulário "frmRelatorioPeriodo" o
        //*** Instancia o Objeto "frmRelatorioPeriodoRecebido" com
        //*** o THIS ***
        public frmRelatorio(frmRelatorioPeriodo _frmRelatorioPeriodoRecebido)
        {
            InitializeComponent();

            //*** Atribui a Herança do THIS (_frmRelatorioPeriodoRecebido)
            //*** para o Objeto do Formulário "frmRelatorioPeriodo"
            _frmRelatorioPeriodo = _frmRelatorioPeriodoRecebido;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //*** Fecha Apenas o Formulário que está Ativo ***
            this.Close();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            //*** Transforma a Seta do Cursor em Espera ***
            this.Cursor = Cursors.WaitCursor;

            //*** Efetua o Carregamento dos Dados do Relatório ***
            objRelatorio.CarregaDadosRelatorio(this, _frmRelatorioPeriodo);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.rptPedidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tlpFechar = new System.Windows.Forms.ToolTip(this.components);
            this.btnAjuda = new System.Windows.Forms.Button();
            this.tlpAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rptPedidos
            // 
            this.rptPedidos.LocalReport.ReportEmbeddedResource = "PacPizzas.03_Camada_Interface.rptPedidos.rdlc";
            this.rptPedidos.Location = new System.Drawing.Point(-1, 0);
            this.rptPedidos.Name = "rptPedidos";
            this.rptPedidos.Size = new System.Drawing.Size(935, 519);
            this.rptPedidos.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.Location = new System.Drawing.Point(844, 527);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 30);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "&F";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpFechar.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjuda.BackgroundImage")));
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAjuda.Location = new System.Drawing.Point(509, 527);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(75, 30);
            this.btnAjuda.TabIndex = 5;
            this.btnAjuda.Text = "&A";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpAjuda.SetToolTip(this.btnAjuda, "Ajuda");
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // frmRelatorio
            // 
            this.ClientSize = new System.Drawing.Size(934, 566);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.rptPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRelatorio_Load_1);
            this.ResumeLayout(false);

        }

        private void frmRelatorio_Load_1(object sender, EventArgs e)
        {
            //*** Transforma a Seta do Cursor em Espera  ***
            this.Cursor = Cursors.WaitCursor;

            //*** Efetua o Carregamento dos Dados do Relatório ***
            objRelatorio.CarregaDadosRelatorio(this, _frmRelatorioPeriodo);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //*** Fecha apenas este formulário sem encerrar a aplicação ***
            this.Close();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Referência no Manual Pac Pizzas" + Convert.ToChar(13) + Convert.ToChar(10) +
                "Pagina: ");
        }
    }
}
