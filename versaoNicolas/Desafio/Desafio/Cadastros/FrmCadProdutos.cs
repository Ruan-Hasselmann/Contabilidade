using BaseDados;
using Entidades;
using System;
using System.Windows.Forms;

namespace Desafio.Cadastros
{
    public partial class FrmCadProdutos : Form
    {

        private bool IsNovo;
        private Produto Cadastro;
        public FrmCadProdutos()
        {
            this.IsNovo = true;
            InitializeComponent();
        }

        private void Bind()
        {
            this.TxtCodigo.DataBindings.Clear();
            this.TxtDescricao.DataBindings.Clear();
            this.TxtEstoque.DataBindings.Clear();
            this.TxtMargem.DataBindings.Clear();


            this.TxtCodigo.DataBindings.Add("Text", this.Cadastro, "Codigo", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtDescricao.DataBindings.Add("Text", this.Cadastro, "Descricao", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtEstoque.DataBindings.Add("Text", this.Cadastro, "Estoque", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtMargem.DataBindings.Add("Text", this.Cadastro, "Margem", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void FrmCadProdutos_Load(object sender, EventArgs e)
        {
            if (IsNovo)
                this.Cadastro = new Produto();

            Bind();
        }

        public FrmCadProdutos(Produto produto)
        {
            InitializeComponent();
            this.Cadastro = produto;
            IsNovo = false;
        }



        private void LimparControles()
        {
            TxtDescricao.Text = string.Empty;
            TxtEstoque.Text = string.Empty;
        }

        private void Inserir()
        {
            try
            {
                Conexao _bd = new Conexao();
                _bd.InserirProduto(this.Cadastro);

                MessageBox.Show("Produto Inserido Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparControles();
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
               _bd.AlterarProduto(this.Cadastro);

                MessageBox.Show("Produto Alterado Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salvar()
        {
            if (!string.IsNullOrEmpty(TxtDescricao.Text))
            {
                if (IsNovo)
                    Inserir();
                else
                    Alterar();

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Buttons
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

                Salvar();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
