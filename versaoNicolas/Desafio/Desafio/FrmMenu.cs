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

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaProdutos frm = new FrmConsultaProdutos();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoProdutos frm = new FrmMovimentacaoProdutos();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
