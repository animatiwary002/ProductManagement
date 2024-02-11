using Microsoft.EntityFrameworkCore;

namespace CrudBackend.Models
{
    public class ProductDataDbContext : DbContext
    {
        public ProductDataDbContext(DbContextOptions<ProductDataDbContext> options) : base(options)
        {
        }

        public DbSet<ProductData> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DUMMY; Initial Catalog=Products; User Id=DUMMYUSERNAME; password=DUMMYPASSWORD; TrustServerCertificate= True");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
