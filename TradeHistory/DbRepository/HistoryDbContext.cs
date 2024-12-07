using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using TradeHistory.Models;

namespace DataLayer.DbRepository
{
    public class HistoryDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Strategy> Strategies { get; set; }
        public DbSet<Operation> Operations { get; set; }

        public HistoryDbContext(DbContextOptions<HistoryDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
