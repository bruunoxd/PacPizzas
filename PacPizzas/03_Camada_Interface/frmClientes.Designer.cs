namespace PacPizzas
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.lblCliente_Sequencial = new System.Windows.Forms.Label();
            this.txtCliente_Sequencial = new System.Windows.Forms.TextBox();
            this.lblCliente_CPF = new System.Windows.Forms.Label();
            this.lblCliente_Nome = new System.Windows.Forms.Label();
            this.txtCliente_Nome = new System.Windows.Forms.TextBox();
            this.lblCliente_Logradouro = new System.Windows.Forms.Label();
            this.lblCliente_Complemento = new System.Windows.Forms.Label();
            this.lblCliente_Bairro = new System.Windows.Forms.Label();
            this.lblCliente_CEP = new System.Windows.Forms.Label();
            this.grbDadosCliente = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCliente_Ponto_Referencia = new System.Windows.Forms.TextBox();
            this.lblCliente_Ponto_Referencia = new System.Windows.Forms.Label();
            this.txtCliente_Numero_Residencia = new System.Windows.Forms.TextBox();
            this.lblCliente_Numero_Residencia = new System.Windows.Forms.Label();
            this.txtCliente_CPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCliente_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCliente_Telefone = new System.Windows.Forms.Label();
            this.txtCliente_CEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCliente_Bairro = new System.Windows.Forms.TextBox();
            this.txtCliente_Complemento = new System.Windows.Forms.TextBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.lblCliente_Status = new System.Windows.Forms.Label();
            this.txtCliente_Logradouro = new System.Windows.Forms.TextBox();
            this.grbRegistros = new System.Windows.Forms.GroupBox();
            this.grbRegistrosObtidos = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.grbOpcaoBusca = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbProcurarEm = new System.Windows.Forms.ComboBox();
            this.lblEm = new System.Windows.Forms.Label();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.tlpExcluir = new System.Windows.Forms.ToolTip(this.components);
            this.tlpSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.tlpNovo_Formulario = new System.Windows.Forms.ToolTip(this.components);
            this.tlpAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.tlpFechar = new System.Windows.Forms.ToolTip(this.components);
            this.tlpBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.grbDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbRegistros.SuspendLayout();
            this.grbRegistrosObtidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.grbOpcaoBusca.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente_Sequencial
            // 
            this.lblCliente_Sequencial.AutoSize = true;
            this.lblCliente_Sequencial.Location = new System.Drawing.Point(5, 22);
            this.lblCliente_Sequencial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_Sequencial.Name = "lblCliente_Sequencial";
            this.lblCliente_Sequencial.Size = new System.Drawing.Size(114, 16);
            this.lblCliente_Sequencial.TabIndex = 0;
            this.lblCliente_Sequencial.Text = "Nro. Sequencial:";
            // 
            // txtCliente_Sequencial
            // 
            this.txtCliente_Sequencial.Location = new System.Drawing.Point(144, 16);
            this.txtCliente_Sequencial.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_Sequencial.Name = "txtCliente_Sequencial";
            this.txtCliente_Sequencial.Size = new System.Drawing.Size(79, 22);
            this.txtCliente_Sequencial.TabIndex = 1;
            this.txtCliente_Sequencial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_Sequencial_KeyDown);
            // 
            // lblCliente_CPF
            // 
            this.lblCliente_CPF.AutoSize = true;
            this.lblCliente_CPF.Location = new System.Drawing.Point(659, 19);
            this.lblCliente_CPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_CPF.Name = "lblCliente_CPF";
            this.lblCliente_CPF.Size = new System.Drawing.Size(34, 16);
            this.lblCliente_CPF.TabIndex = 4;
            this.lblCliente_CPF.Text = "CPF";
            // 
            // lblCliente_Nome
            // 
            this.lblCliente_Nome.AutoSize = true;
            this.lblCliente_Nome.Location = new System.Drawing.Point(231, 22);
            this.lblCliente_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_Nome.Name = "lblCliente_Nome";
            this.lblCliente_Nome.Size = new System.Drawing.Size(49, 16);
            this.lblCliente_Nome.TabIndex = 2;
            this.lblCliente_Nome.Text = "Nome:";
            // 
            // txtCliente_Nome
            // 
            this.txtCliente_Nome.Location = new System.Drawing.Point(288, 16);
            this.txtCliente_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_Nome.Name = "txtCliente_Nome";
            this.txtCliente_Nome.Size = new System.Drawing.Size(367, 22);
            this.txtCliente_Nome.TabIndex = 3;
            this.txtCliente_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_Nome_KeyDown);
            // 
            // lblCliente_Logradouro
            // 
            this.lblCliente_Logradouro.AutoSize = true;
            this.lblCliente_Logradouro.Location = new System.Drawing.Point(5, 55);
            this.lblCliente_Logradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_Logradouro.Name = "lblCliente_Logradouro";
            this.lblCliente_Logradouro.Size = new System.Drawing.Size(86, 16);
            this.lblCliente_Logradouro.TabIndex = 6;
            this.lblCliente_Logradouro.Text = "Logradouro:";
            // 
            // lblCliente_Complemento
            // 
            this.lblCliente_Complemento.AutoSize = true;
            this.lblCliente_Complemento.Location = new System.Drawing.Point(5, 89);
            this.lblCliente_Complemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_Complemento.Name = "lblCliente_Complemento";
            this.lblCliente_Complemento.Size = new System.Drawing.Size(101, 16);
            this.lblCliente_Complemento.TabIndex = 13;
            this.lblCliente_Complemento.Text = "Complemento:";
            // 
            // lblCliente_Bairro
            // 
            this.lblCliente_Bairro.AutoSize = true;
            this.lblCliente_Bairro.Location = new System.Drawing.Point(462, 86);
            this.lblCliente_Bairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_Bairro.Name = "lblCliente_Bairro";
            this.lblCliente_Bairro.Size = new System.Drawing.Size(47, 16);
            this.lblCliente_Bairro.TabIndex = 15;
            this.lblCliente_Bairro.Text = "Bairro";
            // 
            // lblCliente_CEP
            // 
            this.lblCliente_CEP.AutoSize = true;
            this.lblCliente_CEP.Location = new System.Drawing.Point(462, 115);
            this.lblCliente_CEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_CEP.Name = "lblCliente_CEP";
            this.lblCliente_CEP.Size = new System.Drawing.Size(38, 16);
            this.lblCliente_CEP.TabIndex = 19;
            this.lblCliente_CEP.Text = "CEP:";
            // 
            // grbDadosCliente
            // 
            this.grbDadosCliente.Controls.Add(this.pictureBox1);
            this.grbDadosCliente.Controls.Add(this.txtCliente_Ponto_Referencia);
            this.grbDadosCliente.Controls.Add(this.lblCliente_Ponto_Referencia);
            this.grbDadosCliente.Controls.Add(this.txtCliente_Numero_Residencia);
            this.grbDadosCliente.Controls.Add(this.lblCliente_Numero_Residencia);
            this.grbDadosCliente.Controls.Add(this.txtCliente_CPF);
            this.grbDadosCliente.Controls.Add(this.txtCliente_Telefone);
            this.grbDadosCliente.Controls.Add(this.lblCliente_CPF);
            this.grbDadosCliente.Controls.Add(this.lblCliente_Telefone);
            this.grbDadosCliente.Controls.Add(this.txtCliente_CEP);
            this.grbDadosCliente.Controls.Add(this.txtCliente_Bairro);
            this.grbDadosCliente.Controls.Add(this.txtCliente_Complemento);
            this.grbDadosCliente.Controls.Add(this.rdbInativo);
            this.grbDadosCliente.Controls.Add(this.rdbAtivo);
            this.grbDadosCliente.Controls.Add(this.lblCliente_Status);
            this.grbDadosCliente.Controls.Add(this.txtCliente_Logradouro);
            this.grbDadosCliente.Controls.Add(this.lblCliente_CEP);
            this.grbDadosCliente.Controls.Add(this.lblCliente_Bairro);
            this.grbDadosCliente.Controls.Add(this.lblCliente_Complemento);
            this.grbDadosCliente.Controls.Add(this.lblCliente_Logradouro);
            this.grbDadosCliente.Controls.Add(this.txtCliente_Nome);
            this.grbDadosCliente.Controls.Add(this.lblCliente_Nome);
            this.grbDadosCliente.Controls.Add(this.txtCliente_Sequencial);
            this.grbDadosCliente.Controls.Add(this.lblCliente_Sequencial);
            this.grbDadosCliente.Location = new System.Drawing.Point(16, 18);
            this.grbDadosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.grbDadosCliente.Name = "grbDadosCliente";
            this.grbDadosCliente.Padding = new System.Windows.Forms.Padding(4);
            this.grbDadosCliente.Size = new System.Drawing.Size(1024, 160);
            this.grbDadosCliente.TabIndex = 0;
            this.grbDadosCliente.TabStop = false;
            this.grbDadosCliente.Text = "Dados do Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(819, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtCliente_Ponto_Referencia
            // 
            this.txtCliente_Ponto_Referencia.Location = new System.Drawing.Point(144, 112);
            this.txtCliente_Ponto_Referencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_Ponto_Referencia.Name = "txtCliente_Ponto_Referencia";
            this.txtCliente_Ponto_Referencia.Size = new System.Drawing.Size(309, 22);
            this.txtCliente_Ponto_Referencia.TabIndex = 18;
            this.txtCliente_Ponto_Referencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_Ponto_Referencia_KeyDown);
            // 
            // lblCliente_Ponto_Referencia
            // 
            this.lblCliente_Ponto_Referencia.AutoSize = true;
            this.lblCliente_Ponto_Referencia.Location = new System.Drawing.Point(5, 115);
            this.lblCliente_Ponto_Referencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_Ponto_Referencia.Name = "lblCliente_Ponto_Referencia";
            this.lblCliente_Ponto_Referencia.Size = new System.Drawing.Size(142, 16);
            this.lblCliente_Ponto_Referencia.TabIndex = 17;
            this.lblCliente_Ponto_Referencia.Text = "Ponto de Referência:";
            // 
            // txtCliente_Numero_Residencia
            // 
            this.txtCliente_Numero_Residencia.Location = new System.Drawing.Point(523, 48);
            this.txtCliente_Numero_Residencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_Numero_Residencia.MaxLength = 5;
            this.txtCliente_Numero_Residencia.Name = "txtCliente_Numero_Residencia";
            this.txtCliente_Numero_Residencia.Size = new System.Drawing.Size(79, 22);
            this.txtCliente_Numero_Residencia.TabIndex = 9;
            this.txtCliente_Numero_Residencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cliente_numero_residencia_KeyDown);
            // 
            // lblCliente_Numero_Residencia
            // 
            this.lblCliente_Numero_Residencia.AutoSize = true;
            this.lblCliente_Numero_Residencia.Location = new System.Drawing.Point(462, 55);
            this.lblCliente_Numero_Residencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_Numero_Residencia.Name = "lblCliente_Numero_Residencia";
            this.lblCliente_Numero_Residencia.Size = new System.Drawing.Size(62, 16);
            this.lblCliente_Numero_Residencia.TabIndex = 8;
            this.lblCliente_Numero_Residencia.Text = "Numero:";
            // 
            // txtCliente_CPF
            // 
            this.txtCliente_CPF.Location = new System.Drawing.Point(692, 13);
            this.txtCliente_CPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_CPF.Mask = "000,000,000-00";
            this.txtCliente_CPF.Name = "txtCliente_CPF";
            this.txtCliente_CPF.Size = new System.Drawing.Size(112, 22);
            this.txtCliente_CPF.TabIndex = 5;
            this.txtCliente_CPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_CPF_KeyDown);
            // 
            // txtCliente_Telefone
            // 
            this.txtCliente_Telefone.Location = new System.Drawing.Point(681, 112);
            this.txtCliente_Telefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_Telefone.Mask = "(00)00000-0000";
            this.txtCliente_Telefone.Name = "txtCliente_Telefone";
            this.txtCliente_Telefone.Size = new System.Drawing.Size(123, 22);
            this.txtCliente_Telefone.TabIndex = 22;
            this.txtCliente_Telefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_Telefone_KeyDown);
            // 
            // lblCliente_Telefone
            // 
            this.lblCliente_Telefone.AutoSize = true;
            this.lblCliente_Telefone.Location = new System.Drawing.Point(610, 115);
            this.lblCliente_Telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_Telefone.Name = "lblCliente_Telefone";
            this.lblCliente_Telefone.Size = new System.Drawing.Size(67, 16);
            this.lblCliente_Telefone.TabIndex = 21;
            this.lblCliente_Telefone.Text = "Telefone:";
            // 
            // txtCliente_CEP
            // 
            this.txtCliente_CEP.Location = new System.Drawing.Point(523, 112);
            this.txtCliente_CEP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_CEP.Mask = "00000-000";
            this.txtCliente_CEP.Name = "txtCliente_CEP";
            this.txtCliente_CEP.Size = new System.Drawing.Size(79, 22);
            this.txtCliente_CEP.TabIndex = 20;
            this.txtCliente_CEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_CEP_KeyDown);
            // 
            // txtCliente_Bairro
            // 
            this.txtCliente_Bairro.Location = new System.Drawing.Point(523, 80);
            this.txtCliente_Bairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_Bairro.Name = "txtCliente_Bairro";
            this.txtCliente_Bairro.Size = new System.Drawing.Size(281, 22);
            this.txtCliente_Bairro.TabIndex = 16;
            this.txtCliente_Bairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_Bairro_KeyDown);
            // 
            // txtCliente_Complemento
            // 
            this.txtCliente_Complemento.Location = new System.Drawing.Point(143, 80);
            this.txtCliente_Complemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_Complemento.Name = "txtCliente_Complemento";
            this.txtCliente_Complemento.Size = new System.Drawing.Size(311, 22);
            this.txtCliente_Complemento.TabIndex = 14;
            this.txtCliente_Complemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_Complemento_KeyDown);
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(719, 50);
            this.rdbInativo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(69, 20);
            this.rdbInativo.TabIndex = 12;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            this.rdbInativo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbInativo_KeyDown);
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Location = new System.Drawing.Point(662, 51);
            this.rdbAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(58, 20);
            this.rdbAtivo.TabIndex = 11;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            this.rdbAtivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbAtivo_KeyDown);
            // 
            // lblCliente_Status
            // 
            this.lblCliente_Status.AutoSize = true;
            this.lblCliente_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente_Status.Location = new System.Drawing.Point(607, 54);
            this.lblCliente_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente_Status.Name = "lblCliente_Status";
            this.lblCliente_Status.Size = new System.Drawing.Size(47, 13);
            this.lblCliente_Status.TabIndex = 10;
            this.lblCliente_Status.Text = "Status:";
            // 
            // txtCliente_Logradouro
            // 
            this.txtCliente_Logradouro.Location = new System.Drawing.Point(143, 49);
            this.txtCliente_Logradouro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente_Logradouro.Name = "txtCliente_Logradouro";
            this.txtCliente_Logradouro.Size = new System.Drawing.Size(311, 22);
            this.txtCliente_Logradouro.TabIndex = 7;
            this.txtCliente_Logradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_Logradouro_KeyDown);
            // 
            // grbRegistros
            // 
            this.grbRegistros.Controls.Add(this.grbRegistrosObtidos);
            this.grbRegistros.Controls.Add(this.grbOpcaoBusca);
            this.grbRegistros.Location = new System.Drawing.Point(16, 186);
            this.grbRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegistros.Name = "grbRegistros";
            this.grbRegistros.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegistros.Size = new System.Drawing.Size(1024, 353);
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
            this.grbRegistrosObtidos.Size = new System.Drawing.Size(1000, 257);
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
            this.dgvRegistros.Size = new System.Drawing.Size(980, 225);
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
            this.grbOpcaoBusca.Location = new System.Drawing.Point(16, 17);
            this.grbOpcaoBusca.Margin = new System.Windows.Forms.Padding(4);
            this.grbOpcaoBusca.Name = "grbOpcaoBusca";
            this.grbOpcaoBusca.Padding = new System.Windows.Forms.Padding(4);
            this.grbOpcaoBusca.Size = new System.Drawing.Size(1000, 58);
            this.grbOpcaoBusca.TabIndex = 1;
            this.grbOpcaoBusca.TabStop = false;
            this.grbOpcaoBusca.Text = "Opção de Busca";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(920, 12);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 29);
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
            "Nro.Sequencial",
            "Nome",
            "CPF",
            "Logradouro",
            "Numero",
            "Complemento",
            "Bairro",
            "Ponto de Referência",
            "CEP",
            "Telefone",
            "Status"});
            this.cmbProcurarEm.Location = new System.Drawing.Point(563, 15);
            this.cmbProcurarEm.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProcurarEm.Name = "cmbProcurarEm";
            this.cmbProcurarEm.Size = new System.Drawing.Size(349, 24);
            this.cmbProcurarEm.TabIndex = 3;
            this.cmbProcurarEm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProcurarEm_KeyDown);
            // 
            // lblEm
            // 
            this.lblEm.AutoSize = true;
            this.lblEm.Location = new System.Drawing.Point(520, 20);
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
            this.txtBuscarPor.Size = new System.Drawing.Size(411, 22);
            this.txtBuscarPor.TabIndex = 1;
            this.txtBuscarPor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPor_KeyDown);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(8, 25);
            this.lblBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(76, 16);
            this.lblBuscarPor.TabIndex = 0;
            this.lblBuscarPor.Text = "Buscar por";
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(12, 23);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(94, 36);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "&N";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpNovo_Formulario.SetToolTip(this.btnNovo, "Novo Formulário");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravar.BackgroundImage")));
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Location = new System.Drawing.Point(111, 23);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(94, 36);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "&S";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpSalvar.SetToolTip(this.btnGravar, "Salvar");
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(213, 23);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 36);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "&E";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpExcluir.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(921, 23);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 37);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&F";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpFechar.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjuda.BackgroundImage")));
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAjuda.Location = new System.Drawing.Point(579, 22);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(94, 37);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.Text = "&A";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpAjuda.SetToolTip(this.btnAjuda, "Ajuda");
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnAjuda);
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Controls.Add(this.btnExcluir);
            this.grbOpcoes.Controls.Add(this.btnGravar);
            this.grbOpcoes.Controls.Add(this.btnNovo);
            this.grbOpcoes.Location = new System.Drawing.Point(16, 547);
            this.grbOpcoes.Margin = new System.Windows.Forms.Padding(4);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Padding = new System.Windows.Forms.Padding(4);
            this.grbOpcoes.Size = new System.Drawing.Size(1023, 71);
            this.grbOpcoes.TabIndex = 0;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 620);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.grbRegistros);
            this.Controls.Add(this.grbDadosCliente);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes - PAC PIZZA";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.grbDadosCliente.ResumeLayout(false);
            this.grbDadosCliente.PerformLayout();
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

        private System.Windows.Forms.Label lblCliente_Sequencial;
        private System.Windows.Forms.TextBox txtCliente_Sequencial;
        private System.Windows.Forms.Label lblCliente_CPF;
        private System.Windows.Forms.Label lblCliente_Nome;
        private System.Windows.Forms.TextBox txtCliente_Nome;
        private System.Windows.Forms.Label lblCliente_Logradouro;
        private System.Windows.Forms.Label lblCliente_Complemento;
        private System.Windows.Forms.Label lblCliente_Bairro;
        private System.Windows.Forms.Label lblCliente_CEP;
        private System.Windows.Forms.GroupBox grbDadosCliente;
        private System.Windows.Forms.TextBox txtCliente_Bairro;
        private System.Windows.Forms.TextBox txtCliente_Complemento;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.Label lblCliente_Status;
        private System.Windows.Forms.TextBox txtCliente_Logradouro;
        private System.Windows.Forms.GroupBox grbRegistros;
        private System.Windows.Forms.GroupBox grbOpcaoBusca;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.GroupBox grbRegistrosObtidos;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbProcurarEm;
        private System.Windows.Forms.Label lblEm;
        private System.Windows.Forms.MaskedTextBox txtCliente_CPF;
        private System.Windows.Forms.MaskedTextBox txtCliente_CEP;
        private System.Windows.Forms.MaskedTextBox txtCliente_Telefone;
        private System.Windows.Forms.Label lblCliente_Telefone;
        private System.Windows.Forms.TextBox txtCliente_Numero_Residencia;
        private System.Windows.Forms.Label lblCliente_Numero_Residencia;
        private System.Windows.Forms.TextBox txtCliente_Ponto_Referencia;
        private System.Windows.Forms.Label lblCliente_Ponto_Referencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.ToolTip tlpExcluir;
        private System.Windows.Forms.ToolTip tlpNovo_Formulario;
        private System.Windows.Forms.ToolTip tlpSalvar;
        private System.Windows.Forms.ToolTip tlpFechar;
        private System.Windows.Forms.ToolTip tlpAjuda;
        private System.Windows.Forms.ToolTip tlpBuscar;
    }
}