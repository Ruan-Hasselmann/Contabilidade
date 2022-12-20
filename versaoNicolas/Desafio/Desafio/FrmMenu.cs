using System;
using System.Windows.Forms;
using Desafio.Cadastros;

namespace Desafio
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoProdutos frm = new FrmMovimentacaoProdutos();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaProdutos frm = new FrmConsultaProdutos();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frm = new FrmConsultaCliente();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor frm = new FrmConsultaFornecedor();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaGeral frm = new FrmConsultaGeral();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
    
}
