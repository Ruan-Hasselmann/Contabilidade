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
            if (IsNovo)
                this.Cadastro = new Personagem();
            Bind();
        }


        private void Bind() {
           /* this.txtForca.DataBindings.Clear();
            this.TxtDestresa.DataBindings.Clear();
            this.TxtHP.DataBindings.Clear();
            this.txtDefesa.DataBindings.Clear();
            this.TxtPontosLivres.DataBindings.Clear();*/
            /*
            this.txtForca.DataBindings.Add("Text", this.Cadastro, "Forca", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtDestresa.DataBindings.Add("Text", this.Cadastro, "Destresa", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtHP.DataBindings.Add("Text", this.Cadastro, "HP", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtDefesa.DataBindings.Add("Text", this.Cadastro, "Defesa", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtPontosLivres.DataBindings.Add("Text", this.Cadastro, "PontosLivres", false, DataSourceUpdateMode.OnPropertyChanged);*/
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
            /*Conexao _db = new Conexao();
            List<Classe> listaRegistros = _db.ListarClasses();
            FrmPesquisaClasse frm = new FrmPesquisaClasse(listaRegistros.ConvertAll(x => x).ToList<Classe>());
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cadastro.Classe = (Classe)frm.RetornaSelecionado();
                TxtClasse.Text = Cadastro.ClassePersonagem;
                TxtCodClasse.Text = Cadastro.Classe.Codigo.ToString();

                ResetarAtributos();
            }
            else
            {
                MessageBox.Show("Não foram encontradas Classes com este código", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtClasse.Text = string.Empty;
                TxtCodClasse.Text = string.Empty;
            }*/
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

    }
}

