using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bankomat.Models
{
    public class TransactionModel
    {
        public int Id { get; set; }
        public DateTime TransactionTime { get; set; }
        public string TransactionType { get; set; }
        public int AccountId { get; set; }
        public double Balance { get; set; }
        public double Amount { get; set; }
    }
}