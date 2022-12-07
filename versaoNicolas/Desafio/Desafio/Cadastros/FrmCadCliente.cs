﻿using BaseDados;
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
            this.TxtNome.DataBindings.Clear();

            this.TxtCodigo.DataBindings.Add("Text", this.Cadastro, "Codigo", false, DataSourceUpdateMode.OnPropertyChanged);
            this.TxtNome.DataBindings.Add("Text", this.Cadastro, "Descricao", false, DataSourceUpdateMode.OnPropertyChanged);
    

        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            if (IsNovo)
                this.Cadastro = new Cliente();

            Bind();
        }

        public FrmCadCliente(Cliente Cliente
            )
        {
            InitializeComponent();
            this.Cadastro = Cliente;
            IsNovo = false;
        }



        private void LimparControles()
        {
            TxtNome.Text = string.Empty;
           
        }

        private void Inserir()
        {
            try
            {
                Conexao _bd = new Conexao();
                _bd.InserirCliente(this.Cadastro);

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
               _bd.AlterarCliente(this.Cadastro);

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
            if (!string.IsNullOrEmpty(TxtNome.Text))
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