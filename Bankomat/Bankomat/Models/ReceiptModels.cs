using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bankomat.Models
{
    public class ReceiptModels
    {
        public int Id { get; set; }
        public double Length { get; set; } = 14;
        public bool Active { get; set; }
    }
}