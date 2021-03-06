﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bankomat.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bankomat.Models
{
    public class BankAccount
    {
        
        public int Id { get; set; }
        //[ForeignKey("UserId")]
        //public int UserId { get; set; }
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions { get; set; }

        //public ApplicationUser User { get; set; }
        
    }
}