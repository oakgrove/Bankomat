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
        public DbSet<ClickLog> ClickLogs { get; set; }
         
        public DbSet<Money> Money { get; set; }

        public DbSet<UserModels> Users { get; set; }
        public DbSet<BankAccount> Accounts { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public BankomatDbContext() : base("Bankomat")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Bankomat.Models.BankAccount> AccountModels { get; set; }
    }
}