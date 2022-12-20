namespace Desafio
{
    partial class FrmConsultaGeral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnGrid = new System.Windows.Forms.Panel();
            this.PnRodape = new System.Windows.Forms.Panel();
            this.BtnGeral = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvListaRegistros = new Desafio.UserControls.DataGridCustomizada();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClLucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnGrid.SuspendLayout();
            this.PnRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // PnGrid
            // 
            this.PnGrid.Controls.Add(this.DgvListaRegistros);
            this.PnGrid.Location = new System.Drawing.Point(12, 12);
            this.PnGrid.Name = "PnGrid";
            this.PnGrid.Size = new System.Drawing.Size(776, 385);
            this.PnGrid.TabIndex = 0;
            // 
            // PnRodape
            // 
            this.PnRodape.Controls.Add(this.button1);
            this.PnRodape.Controls.Add(this.BtnGeral);
            this.PnRodape.Controls.Add(this.BtnSair);
            this.PnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnRodape.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnRodape.Location = new System.Drawing.Point(0, 403);
            this.PnRodape.Name = "PnRodape";
            this.PnRodape.Size = new System.Drawing.Size(800, 47);
            this.PnRodape.TabIndex = 1;
            // 
            // BtnGeral
            // 
            this.BtnGeral.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnGeral.Location = new System.Drawing.Point(630, 0);
            this.BtnGeral.Name = "BtnGeral";
            this.BtnGeral.Size = new System.Drawing.Size(95, 47);
            this.BtnGeral.TabIndex = 4;
            this.BtnGeral.Text = "Demonstrativo";
            this.BtnGeral.UseVisualStyleBackColor = true;
            this.BtnGeral.Visible = false;
            this.BtnGeral.Click += new System.EventHandler(this.BtnSelecionar_Click);
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(555, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvListaRegistros
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            this.DgvListaRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigo,
            this.clDescricao,
            this.Fornecedor,
            this.Produto,
            this.Total,
            this.ClLucro});
            this.DgvListaRegistros.Location = new System.Drawing.Point(4, 0);
            this.DgvListaRegistros.Name = "DgvListaRegistros";
            this.DgvListaRegistros.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DgvListaRegistros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListaRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaRegistros.Size = new System.Drawing.Size(772, 385);
            this.DgvListaRegistros.TabIndex = 0;
            this.DgvListaRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaRegistros_CellContentClick);
            // 
            // ClCodigo
            // 
            this.ClCodigo.DataPropertyName = "operacao";
            this.ClCodigo.HeaderText = "Operação";
            this.ClCodigo.Name = "ClCodigo";
            // 
            // clDescricao
            // 
            this.clDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDescricao.DataPropertyName = "NomeCLiente";
            this.clDescricao.HeaderText = " Cliente";
            this.clDescricao.Name = "clDescricao";
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "NomeFornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "DescricaoProduto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // ClLucro
            // 
            this.ClLucro.DataPropertyName = "Lucro";
            this.ClLucro.HeaderText = "Lucro %";
            this.ClLucro.Name = "ClLucro";
            // 
            // FrmConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnRodape);
            this.Controls.Add(this.PnGrid);
            this.Name = "FrmConsultaGeral";
            this.Text = "FrmRelatorio";
            this.Load += new System.EventHandler(this.FrmConsultaGeral_Load);
            this.PnGrid.ResumeLayout(false);
            this.PnRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnGrid;
        private System.Windows.Forms.Panel PnRodape;
        private System.Windows.Forms.Button BtnSair;
        private UserControls.DataGridCustomizada DgvListaRegistros;
        private System.Windows.Forms.Button BtnGeral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClLucro;
    }
}