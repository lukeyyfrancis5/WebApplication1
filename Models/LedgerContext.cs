using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Model;

namespace WebApplication1.Models
{
    public class LedgerContext : DbContext
    {
        public DbSet<Ledger> Ledgers { get; set; }
        public DbSet<Coin> Coins { get; set; }
    }
}