using Invoice.Data;
using Invoice.Interface;
using Invoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Services
{
    public class VendaService : IVendaService
    {
        private readonly ApplicationDbContext _dbContext;
       

        public VendaService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Venda> VendasPagas()
        {
            return _dbContext.Vendas.Where(x => x.StatusPagamento == Models.EnumStatusPagamento.Pago);
        }

        public int TotalVendas()
        {
            return 3;
        }
    }
}
