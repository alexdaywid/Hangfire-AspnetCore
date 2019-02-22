using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Models
{
    public enum EnumProduto
    {
        [Display(Name = "SmartPhone Motorola")]
        smartPhone1,
        [Display(Name = "SmartPhone Sansung")]
        smartPhone2,
        [Display(Name = "SmartPhone IPhone")]
        smartPhone3
        
    }
}
