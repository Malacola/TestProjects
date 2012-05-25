using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountAtAGlance.Model;

namespace AccountAtAGlance.Repository
{
    public class AccountAtAGlance : DbContext
    {
        public DbSet<BrokerageAccount> BrokerageAccounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<MarketIndex> MarketIndexes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Security> Securities { get; set; }
        public DbSet<MutualFund> MutualFunds { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }
        public bool IsDisposed { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // inherited table types
            // Map these class names to the table names in the DB
            modelBuilder.Entity<Security>().ToTable("Securities");
            modelBuilder.Entity<Stock>().ToTable("Securities_Stock");
            modelBuilder.Entity<MutualFund>().ToTable("Securities_MutualFund");

            // Many to many resolver
            // Map the WatchList and Securities navigation property using the WatchListSecurity Many-to-Many table.
            // To avoid a Cycle condition, WatchList has Securities, but Security does not have WatchLists.
            modelBuilder.Entity<WatchList>()
                    .HasMany(w => w.Securities).WithMany()
                    .Map(map => map.ToTable("WatchListSecurity")
                    .MapRightKey("SecurityId")
                    .MapLeftKey("WatchListId"));
        }

    }
}
