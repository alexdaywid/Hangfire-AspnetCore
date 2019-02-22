using Invoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Interface
{
    public interface IVendaService
    {
        IEnumerable<Venda> VendasPagas();
    }
}
