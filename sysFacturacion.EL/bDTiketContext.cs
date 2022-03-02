
using Microsoft.EntityFrameworkCore;

namespace sysFacturacion.EL
{
    public class bDTiketContext : DbContext
    {
       
        public DbSet<categori> Categoris { get; set; }
        public DbSet<product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-EMGKJOF\SQLEXPRESS; Initial Catalog = bDTiket; Integrated Security = True");
        }
    }
}
