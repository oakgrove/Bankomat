using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bankomat.Models
{ 
    public class Atm
    {
        public int Id { get; set; }
        public List<Money> Money { get; set; }
        public List<Receipt> Receipts { get; set; }

    }
}