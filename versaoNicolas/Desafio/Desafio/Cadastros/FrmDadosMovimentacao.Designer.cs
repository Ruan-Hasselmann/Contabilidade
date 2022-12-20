namespace Desafio.Cadastros
{
    partial class FrmDadosMovimentacao
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
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnRodape = new System.Windows.Forms.Panel();
            this.TxtDevedor = new System.Windows.Forms.RichTextBox();
            this.TxtCredor = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSair.Location = new System.Drawing.Point(725, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 47);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PnRodape
            // 
            this.PnRodape.Controls.Add(this.BtnSair);
            this.PnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnRodape.Location = new System.Drawing.Point(0, 403);
            this.PnRodape.Name = "PnRodape";
            this.PnRodape.Size = new System.Drawing.Size(800, 47);
            this.PnRodape.TabIndex = 5;
            // 
            // TxtDevedor
            // 
            this.TxtDevedor.Location = new System.Drawing.Point(0, 58);
            this.TxtDevedor.Name = "TxtDevedor";
            this.TxtDevedor.Size = new System.Drawing.Size(342, 339);
            this.TxtDevedor.TabIndex = 6;
            this.TxtDevedor.Text = "";
            // 
            // TxtCredor
            // 
            this.TxtCredor.Location = new System.Drawing.Point(458, 58);
            this.TxtCredor.Name = "TxtCredor";
            this.TxtCredor.Size = new System.Drawing.Size(342, 339);
            this.TxtCredor.TabIndex = 7;
            this.TxtCredor.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Credores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Devedores";
            // 
            // FrmDadosMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCredor);
            this.Controls.Add(this.TxtDevedor);
            this.Controls.Add(this.PnRodape);
            this.Name = "FrmDadosMovimentacao";
            this.Text = "5";
            this.Load += new System.EventHandler(this.FrmDadosMovimentacao_Load);
            this.PnRodape.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Panel PnRodape;
        private System.Windows.Forms.RichTextBox TxtDevedor;
        private System.Windows.Forms.RichTextBox TxtCredor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}