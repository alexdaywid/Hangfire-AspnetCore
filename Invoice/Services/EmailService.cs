using Invoice.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Invoice.Services
{
    public class EmailService : IEmailService
    {
        public void Send()
        {
           var status = "Enviando Email";
        }
    }
}
