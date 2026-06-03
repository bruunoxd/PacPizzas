namespace PacPizzas
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.grbDadosUsuario = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbUsuarioCPF = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario_Senha = new System.Windows.Forms.TextBox();
            this.txtUsuario_Login = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.grbRegistros = new System.Windows.Forms.GroupBox();
            this.grbRegistrosObtidos = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.grbOpcaoBusca = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEm = new System.Windows.Forms.Label();
            this.cmbProcurarEm = new System.Windows.Forms.ComboBox();
            this.txtBuscarPor = new System.Windows.Forms.ComboBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tlpExcluir = new System.Windows.Forms.ToolTip(this.components);
            this.tlpSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.tlpNovo_Formulario = new System.Windows.Forms.ToolTip(this.components);
            this.tlpAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.tlpFechar = new System.Windows.Forms.ToolTip(this.components);
            this.tlpBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.grbDadosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbRegistros.SuspendLayout();
            this.grbRegistrosObtidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.grbOpcaoBusca.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosUsuario
            // 
            this.grbDadosUsuario.Controls.Add(this.pictureBox1);
            this.grbDadosUsuario.Controls.Add(this.cmbUsuarioCPF);
            this.grbDadosUsuario.Controls.Add(this.lblUsuario);
            this.grbDadosUsuario.Controls.Add(this.txtUsuario_Senha);
            this.grbDadosUsuario.Controls.Add(this.txtUsuario_Login);
            this.grbDadosUsuario.Controls.Add(this.lblSenha);
            this.grbDadosUsuario.Controls.Add(this.lblLogin);
            this.grbDadosUsuario.Location = new System.Drawing.Point(16, 15);
            this.grbDadosUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbDadosUsuario.Name = "grbDadosUsuario";
            this.grbDadosUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbDadosUsuario.Size = new System.Drawing.Size(852, 84);
            this.grbDadosUsuario.TabIndex = 0;
            this.grbDadosUsuario.TabStop = false;
            this.grbDadosUsuario.Text = "Dados do Usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(737, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbUsuarioCPF
            // 
            this.cmbUsuarioCPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUsuarioCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioCPF.FormattingEnabled = true;
            this.cmbUsuarioCPF.Items.AddRange(new object[] {
            "000.000.000-00 Administrador"});
            this.cmbUsuarioCPF.Location = new System.Drawing.Point(426, 18);
            this.cmbUsuarioCPF.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuarioCPF.Name = "cmbUsuarioCPF";
            this.cmbUsuarioCPF.Size = new System.Drawing.Size(288, 24);
            this.cmbUsuarioCPF.TabIndex = 5;
            this.cmbUsuarioCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUsuarioCPF_KeyDown);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(333, 27);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 16);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "CPF Usuário:";
            // 
            // txtUsuario_Senha
            // 
            this.txtUsuario_Senha.Location = new System.Drawing.Point(75, 47);
            this.txtUsuario_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario_Senha.Name = "txtUsuario_Senha";
            this.txtUsuario_Senha.Size = new System.Drawing.Size(250, 22);
            this.txtUsuario_Senha.TabIndex = 3;
            this.txtUsuario_Senha.UseSystemPasswordChar = true;
            this.txtUsuario_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_Senha_KeyDown);
            // 
            // txtUsuario_Login
            // 
            this.txtUsuario_Login.Location = new System.Drawing.Point(75, 20);
            this.txtUsuario_Login.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario_Login.Name = "txtUsuario_Login";
            this.txtUsuario_Login.Size = new System.Drawing.Size(250, 22);
            this.txtUsuario_Login.TabIndex = 1;
            this.txtUsuario_Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_Login_KeyDown);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(16, 53);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 16);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(16, 27);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(48, 16);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // grbRegistros
            // 
            this.grbRegistros.Controls.Add(this.grbRegistrosObtidos);
            this.grbRegistros.Controls.Add(this.grbOpcaoBusca);
            this.grbRegistros.Location = new System.Drawing.Point(16, 106);
            this.grbRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegistros.Name = "grbRegistros";
            this.grbRegistros.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegistros.Size = new System.Drawing.Size(852, 277);
            this.grbRegistros.TabIndex = 0;
            this.grbRegistros.TabStop = false;
            this.grbRegistros.Text = "Registros";
            // 
            // grbRegistrosObtidos
            // 
            this.grbRegistrosObtidos.Controls.Add(this.dgvRegistros);
            this.grbRegistrosObtidos.Location = new System.Drawing.Point(9, 97);
            this.grbRegistrosObtidos.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegistrosObtidos.Name = "grbRegistrosObtidos";
            this.grbRegistrosObtidos.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegistrosObtidos.Size = new System.Drawing.Size(836, 167);
            this.grbRegistrosObtidos.TabIndex = 1;
            this.grbRegistrosObtidos.TabStop = false;
            this.grbRegistrosObtidos.Text = "Registros Obtidos";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(8, 16);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.Size = new System.Drawing.Size(820, 144);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            // 
            // grbOpcaoBusca
            // 
            this.grbOpcaoBusca.Controls.Add(this.btnBuscar);
            this.grbOpcaoBusca.Controls.Add(this.lblEm);
            this.grbOpcaoBusca.Controls.Add(this.cmbProcurarEm);
            this.grbOpcaoBusca.Controls.Add(this.txtBuscarPor);
            this.grbOpcaoBusca.Controls.Add(this.lblBuscarPor);
            this.grbOpcaoBusca.Location = new System.Drawing.Point(8, 23);
            this.grbOpcaoBusca.Margin = new System.Windows.Forms.Padding(4);
            this.grbOpcaoBusca.Name = "grbOpcaoBusca";
            this.grbOpcaoBusca.Padding = new System.Windows.Forms.Padding(4);
            this.grbOpcaoBusca.Size = new System.Drawing.Size(837, 66);
            this.grbOpcaoBusca.TabIndex = 1;
            this.grbOpcaoBusca.TabStop = false;
            this.grbOpcaoBusca.Text = "Opções de Busca";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(729, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "&B";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpBuscar.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEm
            // 
            this.lblEm.AutoSize = true;
            this.lblEm.Location = new System.Drawing.Point(460, 27);
            this.lblEm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEm.Name = "lblEm";
            this.lblEm.Size = new System.Drawing.Size(28, 16);
            this.lblEm.TabIndex = 2;
            this.lblEm.Text = "em";
            // 
            // cmbProcurarEm
            // 
            this.cmbProcurarEm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProcurarEm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcurarEm.FormattingEnabled = true;
            this.cmbProcurarEm.Items.AddRange(new object[] {
            "Login",
            "CPF Usuário"});
            this.cmbProcurarEm.Location = new System.Drawing.Point(496, 22);
            this.cmbProcurarEm.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProcurarEm.Name = "cmbProcurarEm";
            this.cmbProcurarEm.Size = new System.Drawing.Size(225, 24);
            this.cmbProcurarEm.TabIndex = 3;
            this.cmbProcurarEm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProcurarEm_KeyDown);
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.FormattingEnabled = true;
            this.txtBuscarPor.Location = new System.Drawing.Point(93, 23);
            this.txtBuscarPor.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(357, 24);
            this.txtBuscarPor.TabIndex = 1;
            this.txtBuscarPor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPor_KeyDown);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(8, 33);
            this.lblBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(80, 16);
            this.lblBuscarPor.TabIndex = 0;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnAjuda);
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Controls.Add(this.btnExcluir);
            this.grbOpcoes.Controls.Add(this.btnGravar);
            this.grbOpcoes.Controls.Add(this.btnNovo);
            this.grbOpcoes.Location = new System.Drawing.Point(16, 390);
            this.grbOpcoes.Margin = new System.Windows.Forms.Padding(4);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Padding = new System.Windows.Forms.Padding(4);
            this.grbOpcoes.Size = new System.Drawing.Size(852, 71);
            this.grbOpcoes.TabIndex = 2;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjuda.BackgroundImage")));
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAjuda.Location = new System.Drawing.Point(504, 27);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(95, 36);
            this.btnAjuda.TabIndex = 3;
            this.btnAjuda.Text = "&A";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpAjuda.SetToolTip(this.btnAjuda, "Ajuda");
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(737, 27);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 36);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&F";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpFechar.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.Location = new System.Drawing.Point(225, 27);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 36);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&E";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpExcluir.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravar.BackgroundImage")));
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Location = new System.Drawing.Point(117, 27);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 36);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "&S";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpSalvar.SetToolTip(this.btnGravar, "Salvar");
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(9, 27);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 36);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&N";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpNovo_Formulario.SetToolTip(this.btnNovo, "Novo Formulário");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 465);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.grbRegistros);
            this.Controls.Add(this.grbDadosUsuario);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários - PAC PIZZA";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.grbDadosUsuario.ResumeLayout(false);
            this.grbDadosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbRegistros.ResumeLayout(false);
            this.grbRegistrosObtidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.grbOpcaoBusca.ResumeLayout(false);
            this.grbOpcaoBusca.PerformLayout();
            this.grbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox grbRegistros;
        private System.Windows.Forms.GroupBox grbRegistrosObtidos;
        private System.Windows.Forms.GroupBox grbOpcaoBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEm;
        private System.Windows.Forms.ComboBox cmbProcurarEm;
        private System.Windows.Forms.ComboBox txtBuscarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.TextBox txtUsuario_Senha;
        private System.Windows.Forms.TextBox txtUsuario_Login;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarioCPF;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpExcluir;
        private System.Windows.Forms.ToolTip tlpSalvar;
        private System.Windows.Forms.ToolTip tlpNovo_Formulario;
        private System.Windows.Forms.ToolTip tlpBuscar;
        private System.Windows.Forms.ToolTip tlpAjuda;
        private System.Windows.Forms.ToolTip tlpFechar;
    }
}