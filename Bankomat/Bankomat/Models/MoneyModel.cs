using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bankomat.Models
{
    public class MoneyModel
    {
        public int Id { get; set; }
        [Display(Name = "Valör")]
        public int Denomination { get; set; }

    }
}