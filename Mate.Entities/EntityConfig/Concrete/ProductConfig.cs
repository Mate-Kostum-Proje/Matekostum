using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class ProductConfig : BaseConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ProductName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.Size).IsRequired().HasMaxLength(50);
            builder.Property(x => x.IsAdult).IsRequired();
            builder.Property(x => x.UnitPriceForSale).IsRequired().HasMaxLength(100000);
            builder.Property(x => x.UnitPiceForRent).HasMaxLength(100000);

            builder.HasOne(p => p.ProductCategories).WithMany(p => p.Products).HasForeignKey(p => p.ProductCategoryId).IsRequired();
            builder.HasOne(p => p.ProductRegions).WithMany(p => p.Products).HasForeignKey(p => p.ProductRegionId).IsRequired();

            //builder.HasData(new Product() { ProductName = "Aşuk Maşuk", IsAdult = true, Size = 14, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });




        }
    }
}
