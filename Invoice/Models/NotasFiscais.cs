using Invoice.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Models
{
    public class NotasFiscais
    {

        public int NotasFiscaisId { get; set; }

        public string Numero { get; set; }

        public float Valor { get; set; }

        public int VendaId { get; set; }

        public Venda Venda { get; set; }
      
    }
}
