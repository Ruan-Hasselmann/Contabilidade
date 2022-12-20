using BaseDados;
using Entidades;
using System;
using System.Windows.Forms;

namespace Desafio.Cadastros
{
    public partial class FrmCadCliente : Form
    {

        private bool IsNovo;
        private Cliente Cadastro;
        public FrmCadCliente()
        {
            this.IsNovo = true;
            InitializeComponent();
        }

        private void Bind()
        {
            this.TxtCodigo.DataBindings.Clear();
            this.TxtDescricao.DataBindings.Clear();


            this.TxtCodigo.DataBindings.Add("Text", this.Cadastro, "Codigo", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtDescricao.DataBindings.Add("Text", this.Cadastro, "nomeCliente", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            if (IsNovo)
                this.Cadastro = new Cliente();

            Bind();
        }

        public FrmCadCliente(Cliente cliente)
        {
            InitializeComponent();
            this.Cadastro = cliente;
            IsNovo = false;
        }



        private void LimparControles()
        {
            TxtDescricao.Text = string.Empty;
        }

        private void Inserir()
        {
            try
            {
                Conexao _bd = new Conexao();
                _bd.InserirCliente(this.Cadastro);

                MessageBox.Show("Cliente Inserido Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
               _bd.AlterarCliente(this.Cadastro);

                MessageBox.Show("Cliente Alterado Com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
