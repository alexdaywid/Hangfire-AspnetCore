using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Invoice.Models;
using Invoice.Data;
using Invoice.Interface;

namespace Invoice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IVendaService _vendaService;
        private readonly INotaFiscalService _notaFiscalService;

        public HomeController(ApplicationDbContext context, INotaFiscalService notaFiscalService, IVendaService vendaService)
        {
            _context = context;
            _notaFiscalService = notaFiscalService;
            _vendaService = vendaService;
        }

        public IActionResult Index()
        {
            //Executado apenas um vez quando é criado.
           // var vendas = _vendaService.VendasPagas();

           // if (vendas != null)
           // {
               // var jobId = BackgroundJob.Enqueue(() => _notaFiscalService.GerarNotaFiscal(vendas));

              //  var jobId1 = BackgroundJob.Schedule(() => _notaFiscalService.GerarNotaFiscal(vendas),TimeSpan.FromMinutes(1));
              
           // }

          //  var cliente = _context.Vendas.Where(x=>x.ClienteId == 2);
          //  ViewBag.Cliente = "Alex";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
