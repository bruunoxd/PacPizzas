namespace PacPizzas
{
    partial class frmEntregas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregas));
            this.lblPedido_Codigo = new System.Windows.Forms.Label();
            this.txtPedido_Codigo = new System.Windows.Forms.TextBox();
            this.grbDadosPedidos = new System.Windows.Forms.GroupBox();
            this.txtPedido_Horario_Saida = new System.Windows.Forms.MaskedTextBox();
            this.lblPedido_Horario_Saida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnItens = new System.Windows.Forms.Button();
            this.btnEntregas = new System.Windows.Forms.Button();
            this.grbRegistros = new System.Windows.Forms.GroupBox();
            this.grbRegistrosObtidos = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.grbBuscaData = new System.Windows.Forms.GroupBox();
            this.txtDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tlpAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.tlpFechar = new System.Windows.Forms.ToolTip(this.components);
            this.tlpBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.tlpSaidaPedido = new System.Windows.Forms.ToolTip(this.components);
            this.tlpVisualizar = new System.Windows.Forms.ToolTip(this.components);
            this.grbDadosPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbRegistros.SuspendLayout();
            this.grbRegistrosObtidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.grbBuscaData.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPedido_Codigo
            // 
            this.lblPedido_Codigo.AutoSize = true;
            this.lblPedido_Codigo.Location = new System.Drawing.Point(8, 22);
            this.lblPedido_Codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedido_Codigo.Name = "lblPedido_Codigo";
            this.lblPedido_Codigo.Size = new System.Drawing.Size(106, 16);
            this.lblPedido_Codigo.TabIndex = 0;
            this.lblPedido_Codigo.Text = "Pedido Código:";
            // 
            // txtPedido_Codigo
            // 
            this.txtPedido_Codigo.Location = new System.Drawing.Point(121, 16);
            this.txtPedido_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPedido_Codigo.Name = "txtPedido_Codigo";
            this.txtPedido_Codigo.Size = new System.Drawing.Size(64, 22);
            this.txtPedido_Codigo.TabIndex = 1;
            // 
            // grbDadosPedidos
            // 
            this.grbDadosPedidos.Controls.Add(this.txtPedido_Horario_Saida);
            this.grbDadosPedidos.Controls.Add(this.lblPedido_Horario_Saida);
            this.grbDadosPedidos.Controls.Add(this.pictureBox1);
            this.grbDadosPedidos.Controls.Add(this.txtPedido_Codigo);
            this.grbDadosPedidos.Controls.Add(this.lblPedido_Codigo);
            this.grbDadosPedidos.Location = new System.Drawing.Point(16, 18);
            this.grbDadosPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.grbDadosPedidos.Name = "grbDadosPedidos";
            this.grbDadosPedidos.Padding = new System.Windows.Forms.Padding(4);
            this.grbDadosPedidos.Size = new System.Drawing.Size(685, 122);
            this.grbDadosPedidos.TabIndex = 0;
            this.grbDadosPedidos.TabStop = false;
            this.grbDadosPedidos.Text = "Dados do Pedido";
            // 
            // txtPedido_Horario_Saida
            // 
            this.txtPedido_Horario_Saida.Location = new System.Drawing.Point(121, 45);
            this.txtPedido_Horario_Saida.Mask = "00:00:00";
            this.txtPedido_Horario_Saida.Name = "txtPedido_Horario_Saida";
            this.txtPedido_Horario_Saida.Size = new System.Drawing.Size(64, 22);
            this.txtPedido_Horario_Saida.TabIndex = 3;
            // 
            // lblPedido_Horario_Saida
            // 
            this.lblPedido_Horario_Saida.AutoSize = true;
            this.lblPedido_Horario_Saida.Location = new System.Drawing.Point(13, 51);
            this.lblPedido_Horario_Saida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedido_Horario_Saida.Name = "lblPedido_Horario_Saida";
            this.lblPedido_Horario_Saida.Size = new System.Drawing.Size(59, 16);
            this.lblPedido_Horario_Saida.TabIndex = 2;
            this.lblPedido_Horario_Saida.Text = "Horário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnItens
            // 
            this.btnItens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItens.BackgroundImage")));
            this.btnItens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnItens.Location = new System.Drawing.Point(19, 23);
            this.btnItens.Name = "btnItens";
            this.btnItens.Size = new System.Drawing.Size(95, 36);
            this.btnItens.TabIndex = 0;
            this.btnItens.Text = "&V";
            this.btnItens.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpVisualizar.SetToolTip(this.btnItens, "Visualizar Itens dos Pedidos");
            this.btnItens.UseVisualStyleBackColor = true;
            this.btnItens.Click += new System.EventHandler(this.btnItens_Click);
            // 
            // btnEntregas
            // 
            this.btnEntregas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntregas.BackgroundImage")));
            this.btnEntregas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntregas.Location = new System.Drawing.Point(127, 22);
            this.btnEntregas.Name = "btnEntregas";
            this.btnEntregas.Size = new System.Drawing.Size(95, 36);
            this.btnEntregas.TabIndex = 1;
            this.btnEntregas.Text = "&S";
            this.btnEntregas.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpSaidaPedido.SetToolTip(this.btnEntregas, "Inserir Horário");
            this.btnEntregas.UseVisualStyleBackColor = true;
            this.btnEntregas.Click += new System.EventHandler(this.btnEntregas_Click);
            // 
            // grbRegistros
            // 
            this.grbRegistros.Controls.Add(this.grbRegistrosObtidos);
            this.grbRegistros.Controls.Add(this.grbBuscaData);
            this.grbRegistros.Location = new System.Drawing.Point(16, 148);
            this.grbRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegistros.Name = "grbRegistros";
            this.grbRegistros.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegistros.Size = new System.Drawing.Size(685, 348);
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
            this.grbRegistrosObtidos.Size = new System.Drawing.Size(659, 256);
            this.grbRegistrosObtidos.TabIndex = 1;
            this.grbRegistrosObtidos.TabStop = false;
            this.grbRegistrosObtidos.Text = "Controle de Entregas";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(8, 23);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.Size = new System.Drawing.Size(639, 225);
            this.dgvRegistros.TabIndex = 2;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            // 
            // grbBuscaData
            // 
            this.grbBuscaData.Controls.Add(this.txtDataPedido);
            this.grbBuscaData.Controls.Add(this.btnBuscar);
            this.grbBuscaData.Controls.Add(this.lblDataPedido);
            this.grbBuscaData.Location = new System.Drawing.Point(16, 20);
            this.grbBuscaData.Margin = new System.Windows.Forms.Padding(4);
            this.grbBuscaData.Name = "grbBuscaData";
            this.grbBuscaData.Padding = new System.Windows.Forms.Padding(4);
            this.grbBuscaData.Size = new System.Drawing.Size(659, 55);
            this.grbBuscaData.TabIndex = 0;
            this.grbBuscaData.TabStop = false;
            this.grbBuscaData.Text = "Buscar Pedido";
            // 
            // txtDataPedido
            // 
            this.txtDataPedido.Location = new System.Drawing.Point(125, 19);
            this.txtDataPedido.Mask = "00/00/0000";
            this.txtDataPedido.Name = "txtDataPedido";
            this.txtDataPedido.Size = new System.Drawing.Size(81, 22);
            this.txtDataPedido.TabIndex = 1;
            this.txtDataPedido.ValidatingType = typeof(System.DateTime);
            this.txtDataPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataPedido_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(545, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&B";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpBuscar.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(8, 25);
            this.lblDataPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(110, 16);
            this.lblDataPedido.TabIndex = 0;
            this.lblDataPedido.Text = "Data do Pedido:";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnItens);
            this.grbOpcoes.Controls.Add(this.btnEntregas);
            this.grbOpcoes.Controls.Add(this.btnAjuda);
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Location = new System.Drawing.Point(16, 496);
            this.grbOpcoes.Margin = new System.Windows.Forms.Padding(4);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Padding = new System.Windows.Forms.Padding(4);
            this.grbOpcoes.Size = new System.Drawing.Size(685, 68);
            this.grbOpcoes.TabIndex = 2;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjuda.BackgroundImage")));
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAjuda.Location = new System.Drawing.Point(343, 23);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(95, 36);
            this.btnAjuda.TabIndex = 2;
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
            this.btnSair.Location = new System.Drawing.Point(579, 23);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 36);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&F";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpFechar.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 567);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.grbRegistros);
            this.Controls.Add(this.grbDadosPedidos);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEntregas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Horário de Entregas - PAC PIZZA";
            this.Load += new System.EventHandler(this.frmEntregas_Load);
            this.grbDadosPedidos.ResumeLayout(false);
            this.grbDadosPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbRegistros.ResumeLayout(false);
            this.grbRegistrosObtidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.grbBuscaData.ResumeLayout(false);
            this.grbBuscaData.PerformLayout();
            this.grbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPedido_Codigo;
        private System.Windows.Forms.TextBox txtPedido_Codigo;
        private System.Windows.Forms.GroupBox grbDadosPedidos;
        private System.Windows.Forms.GroupBox grbRegistros;
        private System.Windows.Forms.GroupBox grbBuscaData;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.GroupBox grbRegistrosObtidos;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpAjuda;
        private System.Windows.Forms.ToolTip tlpFechar;
        private System.Windows.Forms.ToolTip tlpBuscar;
        private System.Windows.Forms.Button btnEntregas;
        private System.Windows.Forms.MaskedTextBox txtPedido_Horario_Saida;
        private System.Windows.Forms.Label lblPedido_Horario_Saida;
        private System.Windows.Forms.MaskedTextBox txtDataPedido;
        private System.Windows.Forms.ToolTip tlpSaidaPedido;
        private System.Windows.Forms.Button btnItens;
        private System.Windows.Forms.ToolTip tlpVisualizar;
    }
}