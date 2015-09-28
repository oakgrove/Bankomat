using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bankomat.Models
{ 
    public class AtmModel
    {
        public int Id { get; set; }
        public List<MoneyModel> Money { get; set; }
        public List<ReceiptModels> Receipts { get; set; }

    }
}