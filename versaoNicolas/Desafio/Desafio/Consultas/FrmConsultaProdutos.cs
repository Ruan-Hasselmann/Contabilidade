using BaseDados;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Desafio.Cadastros;

namespace Desafio
{
    public partial class FrmConsultaProdutos : Form
    {
        private Produto Selecionado;

        public FrmConsultaProdutos()
        {
            InitializeComponent();
        }

        private void FrmConsultaProdutos_Load(object sender, EventArgs e)
        {
            this.DgvListaRegistros.AutoGenerateColumns = false;
            CarregarRegistros();
        }

        private void CarregarRegistros()
        {
            try
            {
                List<Produto> listaRegistros = new Conexao().ListarProdutos();
                this.DgvListaRegistros.DataSource = listaRegistros;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SelecionarRegistro()
        {
            if (DgvListaRegistros.Rows.Count > 0 ){
                try
                {
                    this.Selecionado = (Produto)this.DgvListaRegistros.CurrentRow.DataBoundItem;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
                return false;
        }

        private void InserirRegistro()
        {
            FrmCadProdutos frm = new FrmCadProdutos();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
                CarregarRegistros();
        }

        private void AlterarRegistro()
        {
            if (SelecionarRegistro())
            {
                FrmCadProdutos frm = new FrmCadProdutos(this.Selecionado);
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                    CarregarRegistros();
            }
        }

        private void ExcluirRegistro()
        {
            if (SelecionarRegistro())
            {
                try
                {
                    Conexao _db = new Conexao();
                    _db.ExcluirProduto(this.Selecionado);
                    CarregarRegistros();
                    MessageBox.Show("Produto Deletado Com Sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                        MessageBox.Show("Não é possivel deletar o produto selecionado.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        //Buttons
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            InserirRegistro();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            AlterarRegistro();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
