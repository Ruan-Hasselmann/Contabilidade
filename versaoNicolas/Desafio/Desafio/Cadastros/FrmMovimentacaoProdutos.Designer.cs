namespace Desafio
{
    partial class FrmMovimentacaoProdutos
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
            this.PnRodape = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtProdutoCompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPProdutoCompra = new System.Windows.Forms.Button();
            this.TxtCodProdutoCompra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCodigoCliente = new System.Windows.Forms.TextBox();
            this.BtnBuscarCLiente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtPrazoCompra = new System.Windows.Forms.RadioButton();
            this.TxtVistaCompra = new System.Windows.Forms.RadioButton();
            this.TxtTotalCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtValorCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnConfirmarCompra = new System.Windows.Forms.Button();
            this.TxtQuantiaCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.BtnBuscarFornecedor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LblMstFornecedor = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtPrazoVenda = new System.Windows.Forms.RadioButton();
            this.TxtVistaVenda = new System.Windows.Forms.RadioButton();
            this.TxtTotalVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtValorVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfirmarVenda = new System.Windows.Forms.Button();
            this.TxtQuantiaVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodProdutoVenda = new System.Windows.Forms.TextBox();
            this.BtnPProdutoVenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProdutoVenda = new System.Windows.Forms.Label();
            this.PnRodape.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnRodape
            // 
            this.PnRodape.Controls.Add(this.BtnSair);
            this.PnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnRodape.Location = new System.Drawing.Point(0, 403);
            this.PnRodape.Name = "PnRodape";
            this.PnRodape.Size = new System.Drawing.Size(800, 47);
            this.PnRodape.TabIndex = 44;
            // 
            // BtnSair
            // 
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSair.Location = new System.Drawing.Point(725, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 47);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtProdutoCompra
            // 
            this.TxtProdutoCompra.BackColor = System.Drawing.SystemColors.Control;
            this.TxtProdutoCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtProdutoCompra.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtProdutoCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtProdutoCompra.Location = new System.Drawing.Point(138, 39);
            this.TxtProdutoCompra.Name = "TxtProdutoCompra";
            this.TxtProdutoCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtProdutoCompra.Size = new System.Drawing.Size(185, 17);
            this.TxtProdutoCompra.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Produto";
            // 
            // BtnPProdutoCompra
            // 
            this.BtnPProdutoCompra.Location = new System.Drawing.Point(57, 35);
            this.BtnPProdutoCompra.Name = "BtnPProdutoCompra";
            this.BtnPProdutoCompra.Size = new System.Drawing.Size(75, 23);
            this.BtnPProdutoCompra.TabIndex = 53;
            this.BtnPProdutoCompra.Text = "Pesquisar";
            this.BtnPProdutoCompra.UseVisualStyleBackColor = true;
            this.BtnPProdutoCompra.Click += new System.EventHandler(this.BtnPClasse_Click);
            // 
            // TxtCodProdutoCompra
            // 
            this.TxtCodProdutoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtCodProdutoCompra.Enabled = false;
            this.TxtCodProdutoCompra.Location = new System.Drawing.Point(12, 38);
            this.TxtCodProdutoCompra.Name = "TxtCodProdutoCompra";
            this.TxtCodProdutoCompra.Size = new System.Drawing.Size(32, 20);
            this.TxtCodProdutoCompra.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.TxtCodigoFornecedor);
            this.groupBox1.Controls.Add(this.TxtTotalCompra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtValorCompra);
            this.groupBox1.Controls.Add(this.BtnBuscarFornecedor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnConfirmarCompra);
            this.groupBox1.Controls.Add(this.LblMstFornecedor);
            this.groupBox1.Controls.Add(this.TxtQuantiaCompra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtCodProdutoCompra);
            this.groupBox1.Controls.Add(this.BtnPProdutoCompra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtProdutoCompra);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 396);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comprar";
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtCodigoCliente.Enabled = false;
            this.TxtCodigoCliente.Location = new System.Drawing.Point(6, 82);
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.Size = new System.Drawing.Size(32, 20);
            this.TxtCodigoCliente.TabIndex = 73;
            // 
            // BtnBuscarCLiente
            // 
            this.BtnBuscarCLiente.Location = new System.Drawing.Point(51, 79);
            this.BtnBuscarCLiente.Name = "BtnBuscarCLiente";
            this.BtnBuscarCLiente.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarCLiente.TabIndex = 72;
            this.BtnBuscarCLiente.Text = "Pesquisar";
            this.BtnBuscarCLiente.UseVisualStyleBackColor = true;
            this.BtnBuscarCLiente.Click += new System.EventHandler(this.BtnBuscarCLiente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Cliente";
            // 
            // LblCliente
            // 
            this.LblCliente.BackColor = System.Drawing.SystemColors.Control;
            this.LblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblCliente.Location = new System.Drawing.Point(132, 83);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCliente.Size = new System.Drawing.Size(185, 17);
            this.LblCliente.TabIndex = 70;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtPrazoCompra);
            this.groupBox3.Controls.Add(this.TxtVistaCompra);
            this.groupBox3.Location = new System.Drawing.Point(12, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 49);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagamento";
            // 
            // TxtPrazoCompra
            // 
            this.TxtPrazoCompra.AutoSize = true;
            this.TxtPrazoCompra.Location = new System.Drawing.Point(88, 19);
            this.TxtPrazoCompra.Name = "TxtPrazoCompra";
            this.TxtPrazoCompra.Size = new System.Drawing.Size(61, 17);
            this.TxtPrazoCompra.TabIndex = 71;
            this.TxtPrazoCompra.TabStop = true;
            this.TxtPrazoCompra.Text = "A prazo";
            this.TxtPrazoCompra.UseVisualStyleBackColor = true;
            this.TxtPrazoCompra.CheckedChanged += new System.EventHandler(this.TxtPrazoCompra_CheckedChanged);
            // 
            // TxtVistaCompra
            // 
            this.TxtVistaCompra.AutoSize = true;
            this.TxtVistaCompra.Location = new System.Drawing.Point(6, 19);
            this.TxtVistaCompra.Name = "TxtVistaCompra";
            this.TxtVistaCompra.Size = new System.Drawing.Size(57, 17);
            this.TxtVistaCompra.TabIndex = 70;
            this.TxtVistaCompra.TabStop = true;
            this.TxtVistaCompra.Text = "A vista";
            this.TxtVistaCompra.UseVisualStyleBackColor = true;
            this.TxtVistaCompra.CheckedChanged += new System.EventHandler(this.TxtVistaCompra_CheckedChanged);
            // 
            // TxtTotalCompra
            // 
            this.TxtTotalCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTotalCompra.Enabled = false;
            this.TxtTotalCompra.Location = new System.Drawing.Point(194, 196);
            this.TxtTotalCompra.Name = "TxtTotalCompra";
            this.TxtTotalCompra.Size = new System.Drawing.Size(56, 20);
            this.TxtTotalCompra.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Total";
            // 
            // TxtValorCompra
            // 
            this.TxtValorCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtValorCompra.Location = new System.Drawing.Point(100, 196);
            this.TxtValorCompra.Name = "TxtValorCompra";
            this.TxtValorCompra.Size = new System.Drawing.Size(32, 20);
            this.TxtValorCompra.TabIndex = 66;
            this.TxtValorCompra.Validating += new System.ComponentModel.CancelEventHandler(this.TxtValorCompra_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Valor. Un";
            // 
            // BtnConfirmarCompra
            // 
            this.BtnConfirmarCompra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfirmarCompra.Location = new System.Drawing.Point(3, 346);
            this.BtnConfirmarCompra.Name = "BtnConfirmarCompra";
            this.BtnConfirmarCompra.Size = new System.Drawing.Size(380, 47);
            this.BtnConfirmarCompra.TabIndex = 59;
            this.BtnConfirmarCompra.Text = "Confirmar";
            this.BtnConfirmarCompra.UseVisualStyleBackColor = true;
            this.BtnConfirmarCompra.Click += new System.EventHandler(this.BtnConfirmarCompra_Click);
            // 
            // TxtQuantiaCompra
            // 
            this.TxtQuantiaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtQuantiaCompra.Location = new System.Drawing.Point(12, 196);
            this.TxtQuantiaCompra.Name = "TxtQuantiaCompra";
            this.TxtQuantiaCompra.Size = new System.Drawing.Size(32, 20);
            this.TxtQuantiaCompra.TabIndex = 58;
            this.TxtQuantiaCompra.Validating += new System.ComponentModel.CancelEventHandler(this.TxtQuantiaCompra_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Quantidade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCodigoCliente);
            this.groupBox2.Controls.Add(this.BtnBuscarCLiente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LblCliente);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.TxtTotalVenda);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtValorVenda);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnConfirmarVenda);
            this.groupBox2.Controls.Add(this.TxtQuantiaVenda);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtCodProdutoVenda);
            this.groupBox2.Controls.Add(this.BtnPProdutoVenda);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtProdutoVenda);
            this.groupBox2.Location = new System.Drawing.Point(392, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 396);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vender";
            // 
            // TxtCodigoFornecedor
            // 
            this.TxtCodigoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtCodigoFornecedor.Enabled = false;
            this.TxtCodigoFornecedor.Location = new System.Drawing.Point(12, 83);
            this.TxtCodigoFornecedor.Name = "TxtCodigoFornecedor";
            this.TxtCodigoFornecedor.Size = new System.Drawing.Size(32, 20);
            this.TxtCodigoFornecedor.TabIndex = 77;
            // 
            // BtnBuscarFornecedor
            // 
            this.BtnBuscarFornecedor.Location = new System.Drawing.Point(57, 81);
            this.BtnBuscarFornecedor.Name = "BtnBuscarFornecedor";
            this.BtnBuscarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarFornecedor.TabIndex = 76;
            this.BtnBuscarFornecedor.Text = "Pesquisar";
            this.BtnBuscarFornecedor.UseVisualStyleBackColor = true;
            this.BtnBuscarFornecedor.Click += new System.EventHandler(this.BtnBuscarFornecedor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Fornecedor";
            // 
            // LblMstFornecedor
            // 
            this.LblMstFornecedor.BackColor = System.Drawing.SystemColors.Control;
            this.LblMstFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMstFornecedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblMstFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblMstFornecedor.Location = new System.Drawing.Point(138, 85);
            this.LblMstFornecedor.Name = "LblMstFornecedor";
            this.LblMstFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblMstFornecedor.Size = new System.Drawing.Size(185, 17);
            this.LblMstFornecedor.TabIndex = 74;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtPrazoVenda);
            this.groupBox4.Controls.Add(this.TxtVistaVenda);
            this.groupBox4.Location = new System.Drawing.Point(23, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 49);
            this.groupBox4.TabIndex = 70;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pagamento";
            // 
            // TxtPrazoVenda
            // 
            this.TxtPrazoVenda.AutoSize = true;
            this.TxtPrazoVenda.Location = new System.Drawing.Point(88, 19);
            this.TxtPrazoVenda.Name = "TxtPrazoVenda";
            this.TxtPrazoVenda.Size = new System.Drawing.Size(61, 17);
            this.TxtPrazoVenda.TabIndex = 71;
            this.TxtPrazoVenda.TabStop = true;
            this.TxtPrazoVenda.Text = "A prazo";
            this.TxtPrazoVenda.UseVisualStyleBackColor = true;
            this.TxtPrazoVenda.CheckedChanged += new System.EventHandler(this.TxtPrazoVenda_CheckedChanged);
            // 
            // TxtVistaVenda
            // 
            this.TxtVistaVenda.AutoSize = true;
            this.TxtVistaVenda.Location = new System.Drawing.Point(6, 19);
            this.TxtVistaVenda.Name = "TxtVistaVenda";
            this.TxtVistaVenda.Size = new System.Drawing.Size(57, 17);
            this.TxtVistaVenda.TabIndex = 70;
            this.TxtVistaVenda.TabStop = true;
            this.TxtVistaVenda.Text = "A vista";
            this.TxtVistaVenda.UseVisualStyleBackColor = true;
            this.TxtVistaVenda.CheckedChanged += new System.EventHandler(this.TxtVistaVenda_CheckedChanged);
            // 
            // TxtTotalVenda
            // 
            this.TxtTotalVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTotalVenda.Enabled = false;
            this.TxtTotalVenda.Location = new System.Drawing.Point(195, 196);
            this.TxtTotalVenda.Name = "TxtTotalVenda";
            this.TxtTotalVenda.Size = new System.Drawing.Size(64, 20);
            this.TxtTotalVenda.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Total";
            // 
            // TxtValorVenda
            // 
            this.TxtValorVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtValorVenda.Location = new System.Drawing.Point(101, 196);
            this.TxtValorVenda.Name = "TxtValorVenda";
            this.TxtValorVenda.Size = new System.Drawing.Size(32, 20);
            this.TxtValorVenda.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Valor. Un";
            // 
            // BtnConfirmarVenda
            // 
            this.BtnConfirmarVenda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfirmarVenda.Location = new System.Drawing.Point(3, 346);
            this.BtnConfirmarVenda.Name = "BtnConfirmarVenda";
            this.BtnConfirmarVenda.Size = new System.Drawing.Size(402, 47);
            this.BtnConfirmarVenda.TabIndex = 60;
            this.BtnConfirmarVenda.Text = "Confirmar";
            this.BtnConfirmarVenda.UseVisualStyleBackColor = true;
            this.BtnConfirmarVenda.Click += new System.EventHandler(this.BtnConfirmarVenda_Click);
            // 
            // TxtQuantiaVenda
            // 
            this.TxtQuantiaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtQuantiaVenda.Location = new System.Drawing.Point(13, 196);
            this.TxtQuantiaVenda.Name = "TxtQuantiaVenda";
            this.TxtQuantiaVenda.Size = new System.Drawing.Size(32, 20);
            this.TxtQuantiaVenda.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Quantidade";
            // 
            // TxtCodProdutoVenda
            // 
            this.TxtCodProdutoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtCodProdutoVenda.Enabled = false;
            this.TxtCodProdutoVenda.Location = new System.Drawing.Point(6, 36);
            this.TxtCodProdutoVenda.Name = "TxtCodProdutoVenda";
            this.TxtCodProdutoVenda.Size = new System.Drawing.Size(32, 20);
            this.TxtCodProdutoVenda.TabIndex = 54;
            // 
            // BtnPProdutoVenda
            // 
            this.BtnPProdutoVenda.Location = new System.Drawing.Point(51, 33);
            this.BtnPProdutoVenda.Name = "BtnPProdutoVenda";
            this.BtnPProdutoVenda.Size = new System.Drawing.Size(75, 23);
            this.BtnPProdutoVenda.TabIndex = 53;
            this.BtnPProdutoVenda.Text = "Pesquisar";
            this.BtnPProdutoVenda.UseVisualStyleBackColor = true;
            this.BtnPProdutoVenda.Click += new System.EventHandler(this.BtnPProdutoVenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Produto";
            // 
            // TxtProdutoVenda
            // 
            this.TxtProdutoVenda.BackColor = System.Drawing.SystemColors.Control;
            this.TxtProdutoVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtProdutoVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtProdutoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtProdutoVenda.Location = new System.Drawing.Point(132, 37);
            this.TxtProdutoVenda.Name = "TxtProdutoVenda";
            this.TxtProdutoVenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtProdutoVenda.Size = new System.Drawing.Size(185, 17);
            this.TxtProdutoVenda.TabIndex = 45;
            // 
            // FrmMovimentacaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnRodape);
            this.Name = "FrmMovimentacaoProdutos";
            this.Text = "Movimentações de Produtos";
            this.Load += new System.EventHandler(this.FrmMovimentacaoProdutos_Load);
            this.PnRodape.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnRodape;
        private System.Windows.Forms.Button BtnSair;
        public System.Windows.Forms.Label TxtProdutoCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPProdutoCompra;
        private System.Windows.Forms.TextBox TxtCodProdutoCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTotalCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtValorCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnConfirmarCompra;
        private System.Windows.Forms.TextBox TxtQuantiaCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtTotalVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtValorVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnConfirmarVenda;
        private System.Windows.Forms.TextBox TxtQuantiaVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodProdutoVenda;
        private System.Windows.Forms.Button BtnPProdutoVenda;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label TxtProdutoVenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton TxtPrazoCompra;
        private System.Windows.Forms.RadioButton TxtVistaCompra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton TxtPrazoVenda;
        private System.Windows.Forms.RadioButton TxtVistaVenda;
        private System.Windows.Forms.TextBox TxtCodigoCliente;
        private System.Windows.Forms.Button BtnBuscarCLiente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TxtCodigoFornecedor;
        private System.Windows.Forms.Button BtnBuscarFornecedor;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label LblMstFornecedor;
    }
}

