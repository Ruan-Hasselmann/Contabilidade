using BaseDados;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Desafio.Cadastros;

namespace Desafio
{
    public partial class FrmConsultaCliente : Form
    {
        private Cliente Selecionado;

        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            this.DgvListaRegistros.AutoGenerateColumns = false;
            CarregarRegistros();
        }

        private void CarregarRegistros()
        {
            try
            {
                List<Cliente> listaRegistros = new Conexao().ListarCliente();
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
                    this.Selecionado = (Cliente)this.DgvListaRegistros.CurrentRow.DataBoundItem;
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
            FrmCadCliente frm = new FrmCadCliente();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
                CarregarRegistros();
        }

        private void AlterarRegistro()
        {
            if (SelecionarRegistro())
            {
                FrmCadCliente frm = new FrmCadCliente(this.Selecionado);
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
                    _db.ExcluirCliente(this.Selecionado);
                    CarregarRegistros();
                    MessageBox.Show("Cliente Deletado Com Sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                        MessageBox.Show("Não é possivel deletar o Cliente selecionado.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        public Cliente RetornarSelecionado()
        {
            SelecionarRegistro();
            return this.Selecionado;
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            RetornarSelecionado();
            this.DialogResult = DialogResult.OK;
        }

        private void DgvListaRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
