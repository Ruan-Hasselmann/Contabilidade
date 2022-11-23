using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Produto
    {
        public Produto()
        {

        }

        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public int Estoque { get; set; }

        public double Margem { get; set; }
    }
}
