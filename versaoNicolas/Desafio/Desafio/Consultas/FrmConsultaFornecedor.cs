using BaseDados;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Desafio.Cadastros;

namespace Desafio
{
    public partial class FrmConsultaFornecedor : Form
    {
        private Fornecedor Selecionado;

        public FrmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void FrmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            this.DgvListaRegistros.AutoGenerateColumns = false;
            CarregarRegistros();
        }

        private void CarregarRegistros()
        {
            try
            {
                List<Fornecedor> listaRegistros = new Conexao().ListarFornecedor();
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
                    this.Selecionado = (Fornecedor)this.DgvListaRegistros.CurrentRow.DataBoundItem;
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
            FrmCadFornecedor frm = new FrmCadFornecedor();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
                CarregarRegistros();
        }

        private void AlterarRegistro()
        {
            if (SelecionarRegistro())
            {
                FrmCadFornecedor frm = new FrmCadFornecedor(this.Selecionado);
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
                    _db.ExcluirFornecedor(this.Selecionado);
                    CarregarRegistros();
                    MessageBox.Show("Fornecedor Deletado Com Sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                        MessageBox.Show("Não é possivel deletar o fornecedor selecionado.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        public Fornecedor RetornarSelecionado()
        {
            SelecionarRegistro();
            return this.Selecionado;
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            RetornarSelecionado();
            this.DialogResult = DialogResult.OK;
        }
    }
}
