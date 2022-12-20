using BaseDados;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Desafio.Cadastros;

namespace Desafio
{
    public partial class FrmConsultaGeral : Form
    {
        private VwGeral Selecionado;

        public FrmConsultaGeral()
        {
            InitializeComponent();
        }

        private void FrmConsultaGeral_Load(object sender, EventArgs e)
        {
            this.DgvListaRegistros.AutoGenerateColumns = false;
            CarregarRegistros();
        }

        private void CarregarRegistros()
        {
            try
            {
                List<VwGeral> listaRegistros = new Conexao().ListarVwGeral();
                this.DgvListaRegistros.DataSource = listaRegistros;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SelecionarRegistro()
        {
            if (DgvListaRegistros.Rows.Count > 0)
            {
                try
                {
                    this.Selecionado = (VwGeral)this.DgvListaRegistros.CurrentRow.DataBoundItem;
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public VwGeral RetornarSelecionado()
        {
            SelecionarRegistro();
            return this.Selecionado;
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void DgvListaRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarRegistro();
            FrmDadosMovimentacao frm = new FrmDadosMovimentacao(this.Selecionado);
            frm.ShowDialog();

        }
    }
}
