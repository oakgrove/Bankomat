using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bankomat.Models;

namespace Bankomat.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public List<TransactionModel> Transactions;

    }
}