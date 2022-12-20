using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VwGeral
    {
        public VwGeral()
        {

        }
        public int IdMovimentacao { get; set; }
        public Operacao operacao { get; set; }
        public decimal valor { get; set; }
        public int quantidade { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int? IdCLiente { get; set; }
        public string NomeCLiente { get; set; }
        public int? IdFonecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public int Parcelas { get; set; }
        public int Entrada { get; set; }

        public decimal Total
        {
            get
            {
                return quantidade * valor;
            }
            set
            {

            }
        }
        public decimal Margem { get; set; }
        public decimal Lucro
        {
            get
            {
                if (operacao.Equals(Operacao.Venda))
                {
                    return ((this.Margem * 100) / valor);
                }
                return 0;
            }
            set
            {

            }
        }


    }
}
