using Microsoft.EntityFrameworkCore; 

namespace AspCoreEperiment
{
    public class ApplicationContext: DbContext
    {
        public DbSet<HardwareItemsModel> HardwareItem{get; set;}
        public DbSet<PurchaseItem> PurchaseItems {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ExperementSQLite.db");
        }
    }
}