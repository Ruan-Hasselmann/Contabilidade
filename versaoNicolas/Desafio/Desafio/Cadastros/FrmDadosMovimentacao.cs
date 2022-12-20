using BaseDados;
using Entidades;
using System;
using System.Windows.Forms;

namespace Desafio.Cadastros
{
    public partial class FrmDadosMovimentacao : Form
    {

        private VwGeral obj;
        public FrmDadosMovimentacao()
        {
            InitializeComponent();
        }


        public FrmDadosMovimentacao(VwGeral vwGeral)
        {
            obj = vwGeral;
            InitializeComponent();
        }

            private void FrmDadosMovimentacao_Load(object sender, EventArgs e)
        {
            if (obj.IdFonecedor.HasValue)
            {
                if(obj.TipoPagamento.Equals(TipoPagamento.Vista))
                this.TxtDevedor.Text = string.Concat("Caixa: ", obj.valor, "\r\n");
                else
                {
                    this.TxtDevedor.Text = string.Concat(obj.NomeFornecedor,": ", obj.Total, "\r\n");
                    this.TxtDevedor.Text = string.Concat(TxtDevedor.Text, "\r\n", "Caixa: ", obj.Entrada, "\r\n");
                    this.TxtCredor.Text = string.Concat("Contas a pagar: ", (obj.Total - obj.Entrada).ToString());
                }
            }
            else
            {
                if (obj.TipoPagamento.Equals(TipoPagamento.Vista))
                    this.TxtCredor.Text = string.Concat("Caixa: ", obj.valor, "\r\n");
                else
                {
                    this.TxtCredor.Text = string.Concat(obj.NomeCLiente, ": ", obj.Total, "\r\n");
                    this.TxtCredor.Text = string.Concat(TxtDevedor.Text, "\r\n", "Caixa: ", obj.Entrada, "\r\n");
                    this.TxtDevedor.Text = string.Concat("Contas a receber: ", (obj.Total - obj.Entrada).ToString());
                }
            }
        }


        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
