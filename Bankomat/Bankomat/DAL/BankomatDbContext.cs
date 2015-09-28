using Bankomat.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Bankomat.Models;

namespace Bankomat.DAL
{
    public class BankomatDbContext : DbContext
    {
        public DbSet<ClickLogModels> ClickLogModels { get; set; }

        public DbSet<MoneyModel> Money { get; set; }

        public BankomatDbContext() : base("Bankomat")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}