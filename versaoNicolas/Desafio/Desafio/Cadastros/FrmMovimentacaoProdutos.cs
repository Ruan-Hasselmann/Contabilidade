using BaseDados;
using Entidades;
using Utilitarios;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Desafio.Utilitarios;
using Utilitarios;
using Desafio.Utilitarios;
using System.Globalization;

namespace Desafio
{
    public partial class FrmMovimentacaoProdutos : Form
    {
        private bool IsNovo;
        private Personagem Cadastro;

        private MovimentacaoProduto movimentacaoCompra;

        private MovimentacaoProduto movimentacaoVenda;

        public FrmMovimentacaoProdutos()
        {
            this.IsNovo = true;
            InitializeComponent();
        }

        public FrmMovimentacaoProdutos(Personagem Personagem)
        {
            InitializeComponent();
            this.Cadastro = Personagem;
            IsNovo = false;
        }

        private void FrmMovimentacaoProdutos_Load(object sender, EventArgs e)
        {
            movimentacaoCompra = new MovimentacaoProduto(Operacao.Compra);
            movimentacaoVenda = new MovimentacaoProduto(Operacao.Venda);
            Bind();
            TxtVistaCompra.Checked = true;
            TxtVistaVenda.Checked = true;
        }

        private void BindProdutoCompra()
        {
            this.TxtCodProdutoCompra.DataBindings.Clear();
            this.TxtProdutoCompra.DataBindings.Clear();
            this.TxtQuantiaCompra.DataBindings.Clear();
            this.TxtValorCompra.DataBindings.Clear();
            this.TxtTotalCompra.DataBindings.Clear();

            this.TxtCodProdutoCompra.DataBindings.Add("Text", this.movimentacaoCompra, "CodigoProduto", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtProdutoCompra.DataBindings.Add("Text", this.movimentacaoCompra.Produto, "Descricao", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtQuantiaCompra.DataBindings.Add("Text", this.movimentacaoCompra, "quantidade", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtValorCompra.DataBindings.Add("Text", this.movimentacaoCompra, "valor", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtTotalCompra.DataBindings.Add("Text", this.movimentacaoCompra, "Total", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void BindProdutoVenda()
        {
            this.TxtCodProdutoVenda.DataBindings.Clear();
            this.TxtProdutoVenda.DataBindings.Clear();
            this.TxtQuantiaVenda.DataBindings.Clear();
            this.TxtValorVenda.DataBindings.Clear();
            this.TxtTotalVenda.DataBindings.Clear();

            this.TxtCodProdutoVenda.DataBindings.Add("Text", this.movimentacaoVenda, "CodigoProduto", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtProdutoVenda.DataBindings.Add("Text", this.movimentacaoVenda.Produto, "Descricao", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtQuantiaVenda.DataBindings.Add("Text", this.movimentacaoVenda, "quantidade", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtValorVenda.DataBindings.Add("Text", this.movimentacaoVenda, "valor", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtTotalVenda.DataBindings.Add("Text", this.movimentacaoVenda, "Total", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void Bind() {
            BindProdutoCompra();
            BindProdutoVenda();
        }


        private void Inserir()
        {
            try
            {
                Conexao _bd = new Conexao();
                _bd.InserirPersonagem(this.Cadastro);
                MessageBox.Show("Personagem Inserido Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Alterar()
        {
            try
            {
                Conexao _bd = new Conexao();
                _bd.AlterarPersonagem(this.Cadastro);
                MessageBox.Show("Personagem Alterado Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salvar()
        {
            Bind();
            if (IsNovo)
                Inserir();
            else
                Alterar();
        }


        private void ProcurarClasse()
        {
            Conexao _db = new Conexao();
            List<Produto> listaRegistros = _db.ListarProdutos();
            FrmConsultaProdutos frm = new FrmConsultaProdutos();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog().Equals(DialogResult.OK))
            {
                movimentacaoCompra.Produto = frm.RetornarSelecionado();
                BindProdutoCompra();
            }

        }

        private void ResetarAtributos()
        {   if ((this.Cadastro.Forca - this.Cadastro.Classe.Forca) + (this.Cadastro.HP - this.Cadastro.Classe.HP) + (this.Cadastro.Destresa - this.Cadastro.Classe.Destresa) + (this.Cadastro.Defesa - this.Cadastro.Classe.Defesa) > 0)
                this.Cadastro.PontosLivres = (this.Cadastro.Forca - this.Cadastro.Classe.Forca) + (this.Cadastro.HP - this.Cadastro.Classe.HP) + (this.Cadastro.Destresa - this.Cadastro.Classe.Destresa) + (this.Cadastro.Defesa - this.Cadastro.Classe.Defesa);
            else
                this.Cadastro.PontosLivres = 10;

            this.Cadastro.Forca = this.Cadastro.Classe.Forca;
            this.Cadastro.HP = this.Cadastro.Classe.HP;
            this.Cadastro.Destresa = this.Cadastro.Classe.Destresa;
            this.Cadastro.Defesa = this.Cadastro.Classe.Defesa;

            Bind();
        }

        //Buttons

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void BtnPClasse_Click(object sender, EventArgs e)
        {
            ProcurarClasse();
        }

        private void BtnPGenero_Click(object sender, EventArgs e)
        {
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TxtQuantiaCompra_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtQuantiaCompra.Text) && !string.IsNullOrEmpty(TxtValorCompra.Text))
                this.TxtTotalCompra.Text = (Convert.ToInt64(TxtQuantiaCompra.Text) * Convert.ToInt64(TxtValorCompra.Text)).ToString();
        }

        private void TxtValorCompra_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtQuantiaVenda.Text) && !string.IsNullOrEmpty(TxtValorVenda.Text))
                this.TxtTotalVenda.Text = (Convert.ToInt64(TxtQuantiaVenda.Text) * Convert.ToInt64(TxtValorVenda.Text)).ToString();
        }

        private void InserirCompra()
        {
            Conexao _bd = new Conexao();
            _bd.InserirMovimentacao(this.movimentacaoCompra);
            _bd.AtualizarEstoque(this.movimentacaoCompra);
        }

        private void InserirVenda()
        {
            Conexao _bd = new Conexao();
            _bd.InserirMovimentacao(this.movimentacaoVenda);
            _bd.AtualizarEstoque(this.movimentacaoVenda);
        }
        private void BtnConfirmarCompra_Click(object sender, EventArgs e)
        {
            InserirCompra();
        }

        private void TxtVistaCompra_CheckedChanged(object sender, EventArgs e)
        {
            this.movimentacaoCompra.TipoPagamento = TipoPagamento.Vista;
        }

        private void TxtPrazoCompra_CheckedChanged(object sender, EventArgs e)
        {
            this.movimentacaoCompra.TipoPagamento = TipoPagamento.Prazo;
        }

        private void BtnConfirmarVenda_Click(object sender, EventArgs e)
        {
            InserirVenda();
        }

        private void BtnPProdutoVenda_Click(object sender, EventArgs e)
        {
            Conexao _db = new Conexao();
            List<Produto> listaRegistros = _db.ListarProdutos();
            FrmConsultaProdutos frm = new FrmConsultaProdutos();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog().Equals(DialogResult.OK))
            {
                movimentacaoVenda.Produto = frm.RetornarSelecionado();
                BindProdutoVenda();
            }
        }

        private void TxtVistaVenda_CheckedChanged(object sender, EventArgs e)
        {
            this.movimentacaoVenda.TipoPagamento = TipoPagamento.Vista;

        }

        private void TxtPrazoVenda_CheckedChanged(object sender, EventArgs e)
        {
            this.movimentacaoVenda.TipoPagamento = TipoPagamento.Prazo;

        }
    }
}

