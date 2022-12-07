namespace Desafio
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroFornecedorToolStripMenuItem,
            this.cadastroProdutosToolStripMenuItem,
            this.cadastroClienteToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            this.movimentaçõesToolStripMenuItem.Click += new System.EventHandler(this.movimentaçõesToolStripMenuItem_Click);
            // 
            // cadastroFornecedorToolStripMenuItem
            // 
            this.cadastroFornecedorToolStripMenuItem.Name = "cadastroFornecedorToolStripMenuItem";
            this.cadastroFornecedorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cadastroFornecedorToolStripMenuItem.Text = "Cadastro Fornecedor";
            this.cadastroFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroFornecedorToolStripMenuItem_Click);
            // 
            // cadastroProdutosToolStripMenuItem
            // 
            this.cadastroProdutosToolStripMenuItem.Name = "cadastroProdutosToolStripMenuItem";
            this.cadastroProdutosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cadastroProdutosToolStripMenuItem.Text = "Cadastro Produtos";
            this.cadastroProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutosToolStripMenuItem_Click);
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClienteToolStripMenuItem;
    }
}