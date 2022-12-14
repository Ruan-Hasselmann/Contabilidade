using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VwGeral
    {
        public VwGeral(Operacao op)
        {
            this.Operacao = op;
            this.Produto = new Produto();
            this.Cliente = new Cliente();
        }

        public VwGeral()
        {
            this.Produto = new Produto();
        }

        public int Codigo { get; set; }

        public int? CodigoProduto { get; set; }

        private Produto produto;

        public Produto Produto
        {
            get
            {
                return this.produto;
            }
            set
            {
                this.produto = value;
                if (value != null && value.Codigo > 0)
                    this.CodigoProduto = value.Codigo;
                else
                    this.CodigoProduto = null;
            }
        }

        public Operacao Operacao { get; set; }

        public TipoPagamento TipoPagamento { get; set; }

        public int quantidade { get; set; }

        public double valor { get; set; }

        public double Total
        {
            get
            {
                return quantidade * valor;
            }
            set { }
        }

        public int? CodigoCliente { get; set; }

        private Cliente cliente;

        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
            set
            {
                this.cliente = value;
                if (value != null && value.Codigo > 0)
                    this.CodigoCliente = value.Codigo;
                else
                    this.CodigoCliente = null;
            }
        }

        public int? CodigoFornecedor { get; set; }

        private Fornecedor fornecedor;

        public Fornecedor Fornecedor
        {
            get
            {
                return this.fornecedor;
            }
            set
            {
                this.fornecedor = value;
                if (value != null && value.Codigo > 0)
                    this.CodigoFornecedor = value.Codigo;
                else
                    this.CodigoFornecedor = null;
            }
        }
    }
}
