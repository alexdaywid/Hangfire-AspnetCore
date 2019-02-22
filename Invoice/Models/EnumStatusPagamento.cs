using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Models
{
    public enum EnumStatusPagamento
    {
        [Display(Name = "Pago")]
        Pago,
        [Display(Name = "À Pagar")]
        Apagar
    };
}
