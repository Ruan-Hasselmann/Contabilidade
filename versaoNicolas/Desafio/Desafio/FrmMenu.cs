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

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmConsultaFornecedores frm = new FrmConsultaFornecedores();
            //frm.StartPosition = FormStartPosition.CenterParent;
            //frm.ShowDialog();
        }

        private void cadastroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaProdutos frm = new FrmConsultaProdutos();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmConsultaClientes frm = new FrmConsultaClientes();
            //frm.StartPosition = FormStartPosition.CenterParent;
            //frm.ShowDialog();
        }
    }
}
