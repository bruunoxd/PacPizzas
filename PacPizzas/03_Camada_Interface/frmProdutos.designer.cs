namespace PacPizzas
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.lblProduto_Codigo = new System.Windows.Forms.Label();
            this.txtProduto_Codigo = new System.Windows.Forms.TextBox();
            this.llblProduto_Nome = new System.Windows.Forms.Label();
            this.lblProduto_Descricao = new System.Windows.Forms.Label();
            this.lblProduto_Tamanho = new System.Windows.Forms.Label();
            this.lblProduto_Valor_Unitario = new System.Windows.Forms.Label();
            this.grbDadosProduto = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtProduto_Valor_Unitario = new System.Windows.Forms.MaskedTextBox();
            this.txtProduto_Descricao = new System.Windows.Forms.TextBox();
            this.txtProduto_Tamanho = new System.Windows.Forms.TextBox();
            this.txtProduto_Nome = new System.Windows.Forms.TextBox();
            this.grbRegistros = new System.Windows.Forms.GroupBox();
            this.grbRegistrosObtidos = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.grbOpcaoBusca = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbProcurarEm = new System.Windows.Forms.ComboBox();
            this.lblEm = new System.Windows.Forms.Label();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
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
            this.grbDadosProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbRegistros.SuspendLayout();
            this.grbRegistrosObtidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.grbOpcaoBusca.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProduto_Codigo
            // 
            this.lblProduto_Codigo.AutoSize = true;
            this.lblProduto_Codigo.Location = new System.Drawing.Point(8, 22);
            this.lblProduto_Codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto_Codigo.Name = "lblProduto_Codigo";
            this.lblProduto_Codigo.Size = new System.Drawing.Size(111, 16);
            this.lblProduto_Codigo.TabIndex = 0;
            this.lblProduto_Codigo.Text = "Produto Código:";
            // 
            // txtProduto_Codigo
            // 
            this.txtProduto_Codigo.Location = new System.Drawing.Point(136, 16);
            this.txtProduto_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto_Codigo.Name = "txtProduto_Codigo";
            this.txtProduto_Codigo.Size = new System.Drawing.Size(124, 22);
            this.txtProduto_Codigo.TabIndex = 1;
            this.txtProduto_Codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_Codigo_KeyDown);
            // 
            // llblProduto_Nome
            // 
            this.llblProduto_Nome.AutoSize = true;
            this.llblProduto_Nome.Location = new System.Drawing.Point(8, 55);
            this.llblProduto_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblProduto_Nome.Name = "llblProduto_Nome";
            this.llblProduto_Nome.Size = new System.Drawing.Size(123, 16);
            this.llblProduto_Nome.TabIndex = 2;
            this.llblProduto_Nome.Text = "Nome do Produto:";
            // 
            // lblProduto_Descricao
            // 
            this.lblProduto_Descricao.AutoSize = true;
            this.lblProduto_Descricao.Location = new System.Drawing.Point(8, 87);
            this.lblProduto_Descricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto_Descricao.Name = "lblProduto_Descricao";
            this.lblProduto_Descricao.Size = new System.Drawing.Size(74, 16);
            this.lblProduto_Descricao.TabIndex = 8;
            this.lblProduto_Descricao.Text = "Descrição:";
            // 
            // lblProduto_Tamanho
            // 
            this.lblProduto_Tamanho.AutoSize = true;
            this.lblProduto_Tamanho.Location = new System.Drawing.Point(406, 55);
            this.lblProduto_Tamanho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto_Tamanho.Name = "lblProduto_Tamanho";
            this.lblProduto_Tamanho.Size = new System.Drawing.Size(71, 16);
            this.lblProduto_Tamanho.TabIndex = 4;
            this.lblProduto_Tamanho.Text = "Tamanho:";
            // 
            // lblProduto_Valor_Unitario
            // 
            this.lblProduto_Valor_Unitario.AutoSize = true;
            this.lblProduto_Valor_Unitario.Location = new System.Drawing.Point(668, 55);
            this.lblProduto_Valor_Unitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto_Valor_Unitario.Name = "lblProduto_Valor_Unitario";
            this.lblProduto_Valor_Unitario.Size = new System.Drawing.Size(99, 16);
            this.lblProduto_Valor_Unitario.TabIndex = 6;
            this.lblProduto_Valor_Unitario.Text = "Valor Unitário:";
            // 
            // grbDadosProduto
            // 
            this.grbDadosProduto.Controls.Add(this.pictureBox1);
            this.grbDadosProduto.Controls.Add(this.txtProduto_Valor_Unitario);
            this.grbDadosProduto.Controls.Add(this.txtProduto_Descricao);
            this.grbDadosProduto.Controls.Add(this.txtProduto_Tamanho);
            this.grbDadosProduto.Controls.Add(this.txtProduto_Nome);
            this.grbDadosProduto.Controls.Add(this.lblProduto_Valor_Unitario);
            this.grbDadosProduto.Controls.Add(this.lblProduto_Tamanho);
            this.grbDadosProduto.Controls.Add(this.lblProduto_Descricao);
            this.grbDadosProduto.Controls.Add(this.llblProduto_Nome);
            this.grbDadosProduto.Controls.Add(this.txtProduto_Codigo);
            this.grbDadosProduto.Controls.Add(this.lblProduto_Codigo);
            this.grbDadosProduto.Location = new System.Drawing.Point(16, 18);
            this.grbDadosProduto.Margin = new System.Windows.Forms.Padding(4);
            this.grbDadosProduto.Name = "grbDadosProduto";
            this.grbDadosProduto.Padding = new System.Windows.Forms.Padding(4);
            this.grbDadosProduto.Size = new System.Drawing.Size(1104, 122);
            this.grbDadosProduto.TabIndex = 0;
            this.grbDadosProduto.TabStop = false;
            this.grbDadosProduto.Text = "Dados do Produto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(904, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtProduto_Valor_Unitario
            // 
            this.txtProduto_Valor_Unitario.Location = new System.Drawing.Point(782, 49);
            this.txtProduto_Valor_Unitario.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto_Valor_Unitario.Mask = "$000.00";
            this.txtProduto_Valor_Unitario.Name = "txtProduto_Valor_Unitario";
            this.txtProduto_Valor_Unitario.Size = new System.Drawing.Size(73, 22);
            this.txtProduto_Valor_Unitario.TabIndex = 7;
            this.txtProduto_Valor_Unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProduto_Valor_Unitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_Valor_Unitario_KeyDown);
            // 
            // txtProduto_Descricao
            // 
            this.txtProduto_Descricao.Location = new System.Drawing.Point(136, 81);
            this.txtProduto_Descricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto_Descricao.Name = "txtProduto_Descricao";
            this.txtProduto_Descricao.Size = new System.Drawing.Size(591, 22);
            this.txtProduto_Descricao.TabIndex = 9;
            this.txtProduto_Descricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_Descricao_KeyDown);
            // 
            // txtProduto_Tamanho
            // 
            this.txtProduto_Tamanho.Location = new System.Drawing.Point(480, 49);
            this.txtProduto_Tamanho.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto_Tamanho.Name = "txtProduto_Tamanho";
            this.txtProduto_Tamanho.Size = new System.Drawing.Size(180, 22);
            this.txtProduto_Tamanho.TabIndex = 5;
            this.txtProduto_Tamanho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_Tamanho_KeyDown);
            // 
            // txtProduto_Nome
            // 
            this.txtProduto_Nome.Location = new System.Drawing.Point(136, 49);
            this.txtProduto_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto_Nome.Name = "txtProduto_Nome";
            this.txtProduto_Nome.Size = new System.Drawing.Size(262, 22);
            this.txtProduto_Nome.TabIndex = 3;
            this.txtProduto_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_Nome_KeyDown);
            // 
            // grbRegistros
            // 
            this.grbRegistros.Controls.Add(this.grbRegistrosObtidos);
            this.grbRegistros.Controls.Add(this.grbOpcaoBusca);
            this.grbRegistros.Location = new System.Drawing.Point(16, 148);
            this.grbRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegistros.Name = "grbRegistros";
            this.grbRegistros.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegistros.Size = new System.Drawing.Size(1104, 348);
            this.grbRegistros.TabIndex = 0;
            this.grbRegistros.TabStop = false;
            this.grbRegistros.Text = "Registros";
            // 
            // grbRegistrosObtidos
            // 
            this.grbRegistrosObtidos.Controls.Add(this.dgvRegistros);
            this.grbRegistrosObtidos.Location = new System.Drawing.Point(16, 85);
            this.grbRegistrosObtidos.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegistrosObtidos.Name = "grbRegistrosObtidos";
            this.grbRegistrosObtidos.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegistrosObtidos.Size = new System.Drawing.Size(1080, 256);
            this.grbRegistrosObtidos.TabIndex = 2;
            this.grbRegistrosObtidos.TabStop = false;
            this.grbRegistrosObtidos.Text = "Registros Obtidos";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(12, 23);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.Size = new System.Drawing.Size(1060, 225);
            this.dgvRegistros.TabIndex = 1;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            // 
            // grbOpcaoBusca
            // 
            this.grbOpcaoBusca.Controls.Add(this.btnBuscar);
            this.grbOpcaoBusca.Controls.Add(this.cmbProcurarEm);
            this.grbOpcaoBusca.Controls.Add(this.lblEm);
            this.grbOpcaoBusca.Controls.Add(this.txtBuscarPor);
            this.grbOpcaoBusca.Controls.Add(this.lblBuscarPor);
            this.grbOpcaoBusca.Location = new System.Drawing.Point(16, 20);
            this.grbOpcaoBusca.Margin = new System.Windows.Forms.Padding(4);
            this.grbOpcaoBusca.Name = "grbOpcaoBusca";
            this.grbOpcaoBusca.Padding = new System.Windows.Forms.Padding(4);
            this.grbOpcaoBusca.Size = new System.Drawing.Size(1080, 55);
            this.grbOpcaoBusca.TabIndex = 1;
            this.grbOpcaoBusca.TabStop = false;
            this.grbOpcaoBusca.Text = "Opção de Busca";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(977, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "&B";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpBuscar.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbProcurarEm
            // 
            this.cmbProcurarEm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProcurarEm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcurarEm.FormattingEnabled = true;
            this.cmbProcurarEm.Items.AddRange(new object[] {
            "Produto Código",
            "Nome do Produto",
            "Tamanho",
            "Valor Unitário",
            "Descrição"});
            this.cmbProcurarEm.Location = new System.Drawing.Point(637, 16);
            this.cmbProcurarEm.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProcurarEm.Name = "cmbProcurarEm";
            this.cmbProcurarEm.Size = new System.Drawing.Size(324, 24);
            this.cmbProcurarEm.TabIndex = 3;
            this.cmbProcurarEm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProcurarEm_KeyDown);
            // 
            // lblEm
            // 
            this.lblEm.AutoSize = true;
            this.lblEm.Location = new System.Drawing.Point(584, 20);
            this.lblEm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEm.Name = "lblEm";
            this.lblEm.Size = new System.Drawing.Size(28, 16);
            this.lblEm.TabIndex = 2;
            this.lblEm.Text = "em";
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(93, 16);
            this.txtBuscarPor.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(483, 22);
            this.txtBuscarPor.TabIndex = 1;
            this.txtBuscarPor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPor_KeyDown);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(8, 25);
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
            this.grbOpcoes.Location = new System.Drawing.Point(16, 496);
            this.grbOpcoes.Margin = new System.Windows.Forms.Padding(4);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Padding = new System.Windows.Forms.Padding(4);
            this.grbOpcoes.Size = new System.Drawing.Size(1104, 68);
            this.grbOpcoes.TabIndex = 0;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjuda.BackgroundImage")));
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAjuda.Location = new System.Drawing.Point(653, 20);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(95, 36);
            this.btnAjuda.TabIndex = 4;
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
            this.btnSair.Location = new System.Drawing.Point(993, 23);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 36);
            this.btnSair.TabIndex = 5;
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
            this.btnExcluir.Location = new System.Drawing.Point(213, 20);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 36);
            this.btnExcluir.TabIndex = 3;
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
            this.btnGravar.Location = new System.Drawing.Point(111, 20);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(95, 36);
            this.btnGravar.TabIndex = 2;
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
            this.btnNovo.Location = new System.Drawing.Point(8, 20);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 36);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "&N";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpNovo_Formulario.SetToolTip(this.btnNovo, "Novo Formulário");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 580);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.grbRegistros);
            this.Controls.Add(this.grbDadosProduto);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos - PAC PIZZA";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.grbDadosProduto.ResumeLayout(false);
            this.grbDadosProduto.PerformLayout();
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

        private System.Windows.Forms.Label lblProduto_Codigo;
        private System.Windows.Forms.TextBox txtProduto_Codigo;
        private System.Windows.Forms.Label llblProduto_Nome;
        private System.Windows.Forms.Label lblProduto_Descricao;
        private System.Windows.Forms.Label lblProduto_Tamanho;
        private System.Windows.Forms.Label lblProduto_Valor_Unitario;
        private System.Windows.Forms.GroupBox grbDadosProduto;
        private System.Windows.Forms.TextBox txtProduto_Descricao;
        private System.Windows.Forms.TextBox txtProduto_Tamanho;
        private System.Windows.Forms.TextBox txtProduto_Nome;
        private System.Windows.Forms.GroupBox grbRegistros;
        private System.Windows.Forms.GroupBox grbOpcaoBusca;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.GroupBox grbRegistrosObtidos;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbProcurarEm;
        private System.Windows.Forms.Label lblEm;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.MaskedTextBox txtProduto_Valor_Unitario;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpAjuda;
        private System.Windows.Forms.ToolTip tlpFechar;
        private System.Windows.Forms.ToolTip tlpExcluir;
        private System.Windows.Forms.ToolTip tlpSalvar;
        private System.Windows.Forms.ToolTip tlpNovo_Formulario;
        private System.Windows.Forms.ToolTip tlpBuscar;
    }
}