using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Models
{
    public class Venda
    {
        public int VendaId { get; set; }

        public DateTime DataVenda { get; set; }

        public string Codigo { get; set; }

        public int Quantidade { get; set; }

        public EnumProduto Produto { get; set; }

        public float Valor { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public EnumStatusPagamento StatusPagamento { get; set; }

        public NotasFiscais NotasFiscais { get; set; }

    }
}
