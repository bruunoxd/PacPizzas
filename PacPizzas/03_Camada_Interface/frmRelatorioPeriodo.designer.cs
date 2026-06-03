namespace PacPizzas
{
    partial class frmRelatorioPeriodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioPeriodo));
            this.grbPeriodo = new System.Windows.Forms.GroupBox();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpGerar_Relatorio = new System.Windows.Forms.ToolTip(this.components);
            this.tlpSair = new System.Windows.Forms.ToolTip(this.components);
            this.grbPeriodo.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPeriodo
            // 
            this.grbPeriodo.Controls.Add(this.txtDataFinal);
            this.grbPeriodo.Controls.Add(this.txtDataInicio);
            this.grbPeriodo.Controls.Add(this.lblAte);
            this.grbPeriodo.Controls.Add(this.lblPeriodo);
            this.grbPeriodo.Controls.Add(this.groupBox2);
            this.grbPeriodo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPeriodo.Location = new System.Drawing.Point(150, 8);
            this.grbPeriodo.Name = "grbPeriodo";
            this.grbPeriodo.Size = new System.Drawing.Size(255, 46);
            this.grbPeriodo.TabIndex = 0;
            this.grbPeriodo.TabStop = false;
            this.grbPeriodo.Text = "Periodo";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(180, 16);
            this.txtDataFinal.Mask = "00/00/0000";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(67, 22);
            this.txtDataFinal.TabIndex = 4;
            this.txtDataFinal.ValidatingType = typeof(System.DateTime);
            this.txtDataFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataFinal_KeyDown);
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(70, 16);
            this.txtDataInicio.Mask = "00/00/0000";
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(67, 22);
            this.txtDataInicio.TabIndex = 2;
            this.txtDataInicio.ValidatingType = typeof(System.DateTime);
            this.txtDataInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataInicio_KeyDown);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(146, 19);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(24, 16);
            this.lblAte.TabIndex = 3;
            this.lblAte.Text = "até";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(6, 23);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(65, 16);
            this.lblPeriodo.TabIndex = 1;
            this.lblPeriodo.Text = "Periodo de";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(16, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnGerar);
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOpcoes.Location = new System.Drawing.Point(150, 60);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(255, 72);
            this.grbOpcoes.TabIndex = 0;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnGerar
            // 
            this.btnGerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGerar.BackgroundImage")));
            this.btnGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerar.Location = new System.Drawing.Point(16, 24);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(95, 36);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "&G";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpGerar_Relatorio.SetToolTip(this.btnGerar, "Gerar Relatório");
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(154, 23);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 36);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&S";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpSair.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmRelatorioPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 135);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.grbPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRelatorioPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Faturamento - PAC PIZZA";
            this.Load += new System.EventHandler(this.frmRelatorioPeriodo_Load);
            this.grbPeriodo.ResumeLayout(false);
            this.grbPeriodo.PerformLayout();
            this.grbOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPeriodo;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        private System.Windows.Forms.MaskedTextBox txtDataInicio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpSair;
        private System.Windows.Forms.ToolTip tlpGerar_Relatorio;
    }
}