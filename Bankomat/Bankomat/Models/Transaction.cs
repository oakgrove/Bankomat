using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bankomat.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionTime { get; set; }
        public string TransactionType { get; set; }
        [ForeignKey("AccountId")]
        public int AccountId { get; set; }
        public double Balance { get; set; }
        public double Amount { get; set; }

        public BankAccount Account { get; set; }
    }
}