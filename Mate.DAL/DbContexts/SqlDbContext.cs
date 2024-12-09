using System.Reflection;
using Mate.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Mate.DAL.DbContexts
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<CommUser> CommUsers { get; set; }
        public DbSet<FotoGalery> FotoGaleries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderSituation> OrderSituation { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductRegion> ProductRegions { get; set; }
        public DbSet<SiteCommInfo> SiteCommInfos { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }



        public SqlDbContext()
        {

        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=IDILERDOGAN\\MSSQLSERVER01;Database=MateKostum;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

