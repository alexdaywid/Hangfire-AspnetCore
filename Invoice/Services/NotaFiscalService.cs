using Invoice.Data;
using Invoice.Interface;
using Invoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Services
{
    public class NotaFiscalService : INotaFiscalService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IVendaService _vendaService;


        public NotaFiscalService(ApplicationDbContext dbContext, IVendaService vendaService)
        {
            _dbContext = dbContext;
            _vendaService = vendaService;

        }

        public void Deletar()
        {
            var notas = from n in _dbContext.NotasFiscais
                        select n;

            _dbContext.RemoveRange(notas);
            _dbContext.SaveChanges();
        }

        public void GerarNotaFiscal()
        {
            var vendas = _vendaService.VendasPagas();
            if (vendas != null)
            {
                foreach (var item in vendas)
                {
                    var Nf = new NotasFiscais()
                    {
                        Numero = "000" + item.VendaId,
                        Valor = item.Valor,
                        VendaId = item.VendaId
                    };
                    _dbContext.Add(Nf);
                }
                _dbContext.SaveChanges();
            }
        }

    }
}
