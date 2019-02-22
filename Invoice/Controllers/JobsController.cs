using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Invoice.Data;
using Invoice.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly INotaFiscalService _notaFiscalService;
        private readonly IEmailService _emailService;
        private readonly IVendaService _vendaService;



        public JobsController(ApplicationDbContext dbContext, INotaFiscalService notaFiscalService,
            IEmailService emailService, IVendaService vendaService)
        {
            _dbContext = dbContext;
            _notaFiscalService = notaFiscalService;
            _emailService = emailService;
            _vendaService = vendaService;

        }

        // GET: api/Jobs
        [HttpGet]
        public string Get()
        {

          
           var jobFireForget = BackgroundJob.Enqueue(() => _notaFiscalService.GerarNotaFiscal());

           var jobDelay = BackgroundJob.Schedule(() => _vendaService.VendasPagas(),TimeSpan.FromSeconds(40));

           var jobContinuaco = BackgroundJob.ContinueWith(jobDelay, () => _notaFiscalService.Deletar());

           RecurringJob.AddOrUpdate<IEmailService>(x=>x.Send(),Cron.Daily(23,39));

           RecurringJob.AddOrUpdate<IEmailService>(x => x.Send(), Cron.MinuteInterval(1));
                     
           // RecurringJob.AddOrUpdate( () => _emailService.Send(), "5922**5");

            return "Jobs criado com sucesso";
        }

        // GET: api/Jobs/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Jobs
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Jobs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
