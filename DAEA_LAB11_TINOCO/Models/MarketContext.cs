using Microsoft.EntityFrameworkCore;

namespace DAEA_LAB11_TINOCO.Models
{
    public class MarketContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Detail> Details { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAB1504-15\\SQLEXPRESS;Initial Catalog=MarketDB;User Id=jacko;Password=admin; trustservercertificate=True");
        }
    }
}
