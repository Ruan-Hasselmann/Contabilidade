﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MovimentacaoProduto
    {
        public MovimentacaoProduto()
        {

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
                value = this.produto;
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


    }
}