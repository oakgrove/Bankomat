using Bankomat.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Bankomat.DAL
{
    public class BankomatDbContext : DbContext
    {
        public DbSet<ClickLog> ClickLogModels { get; set; }
         
        public DbSet<Money> Money { get; set; }

        public DbSet<UserModels> User { get; set; }

        public BankomatDbContext() : base("Bankomat")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Bankomat.Models.Account> AccountModels { get; set; }
    }
}