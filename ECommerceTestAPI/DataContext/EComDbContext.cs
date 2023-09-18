using ECommerceTestAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ECommerceTestAPI.DataContext
{
    public class EComDbContext : DbContext
    {
        public EComDbContext() : base()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.configureEntities();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("EComDBConStr");
                optionsBuilder.UseSqlServer(connectionString);
                base.OnConfiguring(optionsBuilder); 
            }
        }

        //Configure your database models
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Attributes> Attributes { get; set; }


    }
}
