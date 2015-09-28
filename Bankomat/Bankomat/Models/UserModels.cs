using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bankomat.Models
{
    public class UserModels
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Account> Accounts { get; set; }
    }
}