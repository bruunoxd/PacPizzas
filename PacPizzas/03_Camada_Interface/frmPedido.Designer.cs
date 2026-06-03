namespace PacPizzas
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.lblPedidoNumero = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.grbPedidoNumero = new System.Windows.Forms.GroupBox();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.lblFuncionarioCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigo_Cliente = new System.Windows.Forms.TextBox();
            this.lblClienteCodigo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.txtPontoReferencia = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblPontoReferencia = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.grbPizzasProdutos = new System.Windows.Forms.GroupBox();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.cbpedido_produto = new System.Windows.Forms.ComboBox();
            this.grbPizzas = new System.Windows.Forms.GroupBox();
            this.lblPizza = new System.Windows.Forms.Label();
            this.btnIncluirPizza = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cbQuantidade = new System.Windows.Forms.ComboBox();
            this.cbpedido_pizza = new System.Windows.Forms.ComboBox();
            this.grbConclusao = new System.Windows.Forms.GroupBox();
            this.btnCalcula_Troco = new System.Windows.Forms.Button();
            this.txtReceber = new System.Windows.Forms.MaskedTextBox();
            this.item_codigoExcluir = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblReceber = new System.Windows.Forms.Label();
            this.Pedido_Total = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnExcluirItens = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpFechar = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tlpAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.tlpBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEntregas = new System.Windows.Forms.Button();
            this.btnItens = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tlpVisualizar = new System.Windows.Forms.ToolTip(this.components);
            this.tlpSaidaPedido = new System.Windows.Forms.ToolTip(this.components);
            this.grbPedidoNumero.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grbPizzasProdutos.SuspendLayout();
            this.grbProdutos.SuspendLayout();
            this.grbPizzas.SuspendLayout();
            this.grbConclusao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPedidoNumero
            // 
            this.lblPedidoNumero.AutoSize = true;
            this.lblPedidoNumero.Location = new System.Drawing.Point(4, 13);
            this.lblPedidoNumero.Name = "lblPedidoNumero";
            this.lblPedidoNumero.Size = new System.Drawing.Size(59, 14);
            this.lblPedidoNumero.TabIndex = 0;
            this.lblPedidoNumero.Text = "Pedido Nº";
            // 
            // txtPedido
            // 
            this.txtPedido.Enabled = false;
            this.txtPedido.Location = new System.Drawing.Point(70, 10);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(69, 20);
            this.txtPedido.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(202, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 14);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(362, 14);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(50, 14);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horário:";
            // 
            // grbPedidoNumero
            // 
            this.grbPedidoNumero.Controls.Add(this.txtHorario);
            this.grbPedidoNumero.Controls.Add(this.txtCPF);
            this.grbPedidoNumero.Controls.Add(this.txtData);
            this.grbPedidoNumero.Controls.Add(this.lblPedidoNumero);
            this.grbPedidoNumero.Controls.Add(this.lblFuncionarioCPF);
            this.grbPedidoNumero.Controls.Add(this.txtPedido);
            this.grbPedidoNumero.Controls.Add(this.lblData);
            this.grbPedidoNumero.Controls.Add(this.lblHorario);
            this.grbPedidoNumero.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPedidoNumero.Location = new System.Drawing.Point(5, 1);
            this.grbPedidoNumero.Name = "grbPedidoNumero";
            this.grbPedidoNumero.Size = new System.Drawing.Size(722, 42);
            this.grbPedidoNumero.TabIndex = 0;
            this.grbPedidoNumero.TabStop = false;
            // 
            // txtHorario
            // 
            this.txtHorario.Enabled = false;
            this.txtHorario.Location = new System.Drawing.Point(419, 11);
            this.txtHorario.Mask = "00:00:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(64, 20);
            this.txtHorario.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(608, 11);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 7;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(243, 11);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(74, 20);
            this.txtData.TabIndex = 3;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // lblFuncionarioCPF
            // 
            this.lblFuncionarioCPF.AutoSize = true;
            this.lblFuncionarioCPF.Location = new System.Drawing.Point(504, 14);
            this.lblFuncionarioCPF.Name = "lblFuncionarioCPF";
            this.lblFuncionarioCPF.Size = new System.Drawing.Size(98, 14);
            this.lblFuncionarioCPF.TabIndex = 6;
            this.lblFuncionarioCPF.Text = "CPF Funcionário:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(9, 25);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 14);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(72, 21);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(116, 20);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefone_KeyDown);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(749, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 36);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&F";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpFechar.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo_Cliente);
            this.groupBox1.Controls.Add(this.lblClienteCodigo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnAlterarDados);
            this.groupBox1.Controls.Add(this.txtPontoReferencia);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.lblPontoReferencia);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // txtCodigo_Cliente
            // 
            this.txtCodigo_Cliente.Enabled = false;
            this.txtCodigo_Cliente.Location = new System.Drawing.Point(134, 66);
            this.txtCodigo_Cliente.Name = "txtCodigo_Cliente";
            this.txtCodigo_Cliente.Size = new System.Drawing.Size(186, 20);
            this.txtCodigo_Cliente.TabIndex = 4;
            // 
            // lblClienteCodigo
            // 
            this.lblClienteCodigo.AutoSize = true;
            this.lblClienteCodigo.Location = new System.Drawing.Point(6, 69);
            this.lblClienteCodigo.Name = "lblClienteCodigo";
            this.lblClienteCodigo.Size = new System.Drawing.Size(91, 14);
            this.lblClienteCodigo.TabIndex = 3;
            this.lblClienteCodigo.Text = "Cliente Código:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(194, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&B";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpBuscar.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.Location = new System.Drawing.Point(41, 225);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(250, 23);
            this.btnAlterarDados.TabIndex = 13;
            this.btnAlterarDados.Text = "&Cadastrar/Alterar Dados do Cliente";
            this.btnAlterarDados.UseVisualStyleBackColor = true;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // txtPontoReferencia
            // 
            this.txtPontoReferencia.Enabled = false;
            this.txtPontoReferencia.Location = new System.Drawing.Point(134, 190);
            this.txtPontoReferencia.Name = "txtPontoReferencia";
            this.txtPontoReferencia.Size = new System.Drawing.Size(186, 20);
            this.txtPontoReferencia.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(134, 160);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(186, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // lblPontoReferencia
            // 
            this.lblPontoReferencia.AutoSize = true;
            this.lblPontoReferencia.Location = new System.Drawing.Point(6, 193);
            this.lblPontoReferencia.Name = "lblPontoReferencia";
            this.lblPontoReferencia.Size = new System.Drawing.Size(121, 14);
            this.lblPontoReferencia.TabIndex = 11;
            this.lblPontoReferencia.Text = "Ponto de Referência:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(134, 128);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(186, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 163);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(43, 14);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(134, 95);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(186, 20);
            this.txtCliente.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(6, 131);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(62, 14);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 98);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 14);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente:";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(6, 19);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(840, 216);
            this.dgvPedido.TabIndex = 0;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // grbPizzasProdutos
            // 
            this.grbPizzasProdutos.Controls.Add(this.grbProdutos);
            this.grbPizzasProdutos.Controls.Add(this.grbPizzas);
            this.grbPizzasProdutos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPizzasProdutos.Location = new System.Drawing.Point(337, 49);
            this.grbPizzasProdutos.Name = "grbPizzasProdutos";
            this.grbPizzasProdutos.Size = new System.Drawing.Size(390, 165);
            this.grbPizzasProdutos.TabIndex = 2;
            this.grbPizzasProdutos.TabStop = false;
            this.grbPizzasProdutos.Text = "Pedidos Pizzas/Produtos";
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.btnProdutos);
            this.grbProdutos.Controls.Add(this.lblProdutos);
            this.grbProdutos.Controls.Add(this.cbpedido_produto);
            this.grbProdutos.Location = new System.Drawing.Point(6, 105);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(378, 56);
            this.grbProdutos.TabIndex = 2;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "Outros Produtos";
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(274, 20);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(98, 26);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "I&ncluir";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(6, 26);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(61, 14);
            this.lblProdutos.TabIndex = 0;
            this.lblProdutos.Text = "Produtos:";
            // 
            // cbpedido_produto
            // 
            this.cbpedido_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpedido_produto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpedido_produto.FormattingEnabled = true;
            this.cbpedido_produto.Location = new System.Drawing.Point(69, 23);
            this.cbpedido_produto.Name = "cbpedido_produto";
            this.cbpedido_produto.Size = new System.Drawing.Size(202, 22);
            this.cbpedido_produto.TabIndex = 1;
            this.cbpedido_produto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbpedido_produto_KeyDown);
            // 
            // grbPizzas
            // 
            this.grbPizzas.Controls.Add(this.lblPizza);
            this.grbPizzas.Controls.Add(this.btnIncluirPizza);
            this.grbPizzas.Controls.Add(this.lblQuantidade);
            this.grbPizzas.Controls.Add(this.cbQuantidade);
            this.grbPizzas.Controls.Add(this.cbpedido_pizza);
            this.grbPizzas.Location = new System.Drawing.Point(6, 19);
            this.grbPizzas.Name = "grbPizzas";
            this.grbPizzas.Size = new System.Drawing.Size(378, 80);
            this.grbPizzas.TabIndex = 1;
            this.grbPizzas.TabStop = false;
            this.grbPizzas.Text = "Pizzas";
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(5, 24);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(38, 14);
            this.lblPizza.TabIndex = 0;
            this.lblPizza.Text = "Pizza:";
            // 
            // btnIncluirPizza
            // 
            this.btnIncluirPizza.Location = new System.Drawing.Point(274, 47);
            this.btnIncluirPizza.Name = "btnIncluirPizza";
            this.btnIncluirPizza.Size = new System.Drawing.Size(98, 26);
            this.btnIncluirPizza.TabIndex = 4;
            this.btnIncluirPizza.Text = "&Incluir ";
            this.btnIncluirPizza.UseVisualStyleBackColor = true;
            this.btnIncluirPizza.Click += new System.EventHandler(this.btnIncluirPizza_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(4, 55);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(72, 14);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // cbQuantidade
            // 
            this.cbQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantidade.FormattingEnabled = true;
            this.cbQuantidade.Items.AddRange(new object[] {
            "0,5",
            "1"});
            this.cbQuantidade.Location = new System.Drawing.Point(80, 51);
            this.cbQuantidade.Name = "cbQuantidade";
            this.cbQuantidade.Size = new System.Drawing.Size(50, 22);
            this.cbQuantidade.TabIndex = 3;
            this.cbQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbQuantidade_KeyDown);
            // 
            // cbpedido_pizza
            // 
            this.cbpedido_pizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpedido_pizza.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpedido_pizza.FormattingEnabled = true;
            this.cbpedido_pizza.Location = new System.Drawing.Point(46, 21);
            this.cbpedido_pizza.Name = "cbpedido_pizza";
            this.cbpedido_pizza.Size = new System.Drawing.Size(326, 22);
            this.cbpedido_pizza.TabIndex = 1;
            this.cbpedido_pizza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbpedido_pizza_KeyDown);
            // 
            // grbConclusao
            // 
            this.grbConclusao.Controls.Add(this.btnCalcula_Troco);
            this.grbConclusao.Controls.Add(this.txtReceber);
            this.grbConclusao.Controls.Add(this.item_codigoExcluir);
            this.grbConclusao.Controls.Add(this.txtTroco);
            this.grbConclusao.Controls.Add(this.lblTroco);
            this.grbConclusao.Controls.Add(this.lblReceber);
            this.grbConclusao.Controls.Add(this.Pedido_Total);
            this.grbConclusao.Controls.Add(this.lblTotalPagar);
            this.grbConclusao.Controls.Add(this.btnFinalizarPedido);
            this.grbConclusao.Controls.Add(this.btnExcluirItens);
            this.grbConclusao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConclusao.Location = new System.Drawing.Point(337, 216);
            this.grbConclusao.Name = "grbConclusao";
            this.grbConclusao.Size = new System.Drawing.Size(520, 87);
            this.grbConclusao.TabIndex = 3;
            this.grbConclusao.TabStop = false;
            this.grbConclusao.Text = "Conclusão do Pedido";
            // 
            // btnCalcula_Troco
            // 
            this.btnCalcula_Troco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula_Troco.Location = new System.Drawing.Point(5, 58);
            this.btnCalcula_Troco.Name = "btnCalcula_Troco";
            this.btnCalcula_Troco.Size = new System.Drawing.Size(102, 23);
            this.btnCalcula_Troco.TabIndex = 6;
            this.btnCalcula_Troco.Text = "Calcular &Troco ";
            this.btnCalcula_Troco.UseVisualStyleBackColor = true;
            this.btnCalcula_Troco.Click += new System.EventHandler(this.btnCalcula_Troco_Click);
            // 
            // txtReceber
            // 
            this.txtReceber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceber.Location = new System.Drawing.Point(257, 17);
            this.txtReceber.Mask = "000.00";
            this.txtReceber.Name = "txtReceber";
            this.txtReceber.Size = new System.Drawing.Size(50, 25);
            this.txtReceber.TabIndex = 3;
            this.txtReceber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceber_KeyDown);
            // 
            // item_codigoExcluir
            // 
            this.item_codigoExcluir.Location = new System.Drawing.Point(157, 58);
            this.item_codigoExcluir.Name = "item_codigoExcluir";
            this.item_codigoExcluir.Size = new System.Drawing.Size(20, 20);
            this.item_codigoExcluir.TabIndex = 7;
            this.item_codigoExcluir.Visible = false;
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(461, 17);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(50, 25);
            this.txtTroco.TabIndex = 5;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(404, 20);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(53, 18);
            this.lblTroco.TabIndex = 4;
            this.lblTroco.Text = "Troco:";
            // 
            // lblReceber
            // 
            this.lblReceber.AutoSize = true;
            this.lblReceber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceber.Location = new System.Drawing.Point(166, 20);
            this.lblReceber.Name = "lblReceber";
            this.lblReceber.Size = new System.Drawing.Size(86, 18);
            this.lblReceber.TabIndex = 2;
            this.lblReceber.Text = "Á Receber:";
            // 
            // Pedido_Total
            // 
            this.Pedido_Total.Enabled = false;
            this.Pedido_Total.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pedido_Total.Location = new System.Drawing.Point(57, 17);
            this.Pedido_Total.Name = "Pedido_Total";
            this.Pedido_Total.Size = new System.Drawing.Size(50, 25);
            this.Pedido_Total.TabIndex = 1;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(4, 20);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(47, 18);
            this.lblTotalPagar.TabIndex = 0;
            this.lblTotalPagar.Text = "Total:";
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.Location = new System.Drawing.Point(404, 58);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(107, 23);
            this.btnFinalizarPedido.TabIndex = 9;
            this.btnFinalizarPedido.Text = "&Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnExcluirItens
            // 
            this.btnExcluirItens.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItens.Location = new System.Drawing.Point(183, 58);
            this.btnExcluirItens.Name = "btnExcluirItens";
            this.btnExcluirItens.Size = new System.Drawing.Size(159, 23);
            this.btnExcluirItens.TabIndex = 8;
            this.btnExcluirItens.Text = "&Excluir Itens da Lista";
            this.btnExcluirItens.UseVisualStyleBackColor = true;
            this.btnExcluirItens.Click += new System.EventHandler(this.btnExcluirItens_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(733, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Help;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(398, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "&A";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpAjuda.SetToolTip(this.button1, "Ajuda");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEntregas);
            this.groupBox2.Controls.Add(this.btnItens);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 556);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 49);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // btnEntregas
            // 
            this.btnEntregas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntregas.BackgroundImage")));
            this.btnEntregas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntregas.Location = new System.Drawing.Point(170, 10);
            this.btnEntregas.Name = "btnEntregas";
            this.btnEntregas.Size = new System.Drawing.Size(95, 36);
            this.btnEntregas.TabIndex = 1;
            this.btnEntregas.Text = "&E";
            this.btnEntregas.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpSaidaPedido.SetToolTip(this.btnEntregas, "Entregas");
            this.btnEntregas.UseVisualStyleBackColor = true;
            this.btnEntregas.Click += new System.EventHandler(this.btnEntregas_Click);
            // 
            // btnItens
            // 
            this.btnItens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItens.BackgroundImage")));
            this.btnItens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnItens.Location = new System.Drawing.Point(60, 10);
            this.btnItens.Name = "btnItens";
            this.btnItens.Size = new System.Drawing.Size(95, 36);
            this.btnItens.TabIndex = 0;
            this.btnItens.Text = "&V";
            this.btnItens.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tlpVisualizar.SetToolTip(this.btnItens, "Visualizar Itens dos Pedidos");
            this.btnItens.UseVisualStyleBackColor = true;
            this.btnItens.Click += new System.EventHandler(this.btnItens_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPedido);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(852, 241);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Itens do Pedido";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 607);
            this.Controls.Add(this.grbConclusao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbPizzasProdutos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbPedidoNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pedidos - PAC PIZZA";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.grbPedidoNumero.ResumeLayout(false);
            this.grbPedidoNumero.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grbPizzasProdutos.ResumeLayout(false);
            this.grbProdutos.ResumeLayout(false);
            this.grbProdutos.PerformLayout();
            this.grbPizzas.ResumeLayout(false);
            this.grbPizzas.PerformLayout();
            this.grbConclusao.ResumeLayout(false);
            this.grbConclusao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPedidoNumero;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.GroupBox grbPedidoNumero;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblFuncionarioCPF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblPontoReferencia;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtPontoReferencia;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.GroupBox grbPizzasProdutos;
        private System.Windows.Forms.GroupBox grbConclusao;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnExcluirItens;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.ComboBox cbpedido_produto;
        private System.Windows.Forms.GroupBox grbPizzas;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Button btnIncluirPizza;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cbQuantidade;
        private System.Windows.Forms.ComboBox cbpedido_pizza;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblReceber;
        private System.Windows.Forms.TextBox Pedido_Total;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtCodigo_Cliente;
        private System.Windows.Forms.Label lblClienteCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpFechar;
        private System.Windows.Forms.ToolTip tlpBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip tlpAjuda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtReceber;
        private System.Windows.Forms.Button btnCalcula_Troco;
        private System.Windows.Forms.TextBox item_codigoExcluir;
        private System.Windows.Forms.Button btnItens;
        private System.Windows.Forms.ToolTip tlpVisualizar;
        private System.Windows.Forms.Button btnEntregas;
        private System.Windows.Forms.ToolTip tlpSaidaPedido;
    }
}