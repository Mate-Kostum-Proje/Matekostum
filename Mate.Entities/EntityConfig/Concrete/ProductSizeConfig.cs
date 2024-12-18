using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class ProductSizeConfig : BaseConfig<ProductSize>
    {
        public override void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.Sizes).WithMany(p => p.ProductSizes).HasForeignKey(p => p.SizeId).IsRequired();
            builder.HasOne(p => p.Products).WithMany(p => p.ProductSizes).HasForeignKey(p => p.ProductId).IsRequired();


            builder.HasIndex(p => p.SizeNumber);
            builder.HasIndex(P => P.ProductName);
            builder.HasIndex(P => P.SizeAmount);

            builder.HasData(new ProductSize { ProductName = "", SizeNumber = 8, SizeAmount = 3 });
        }
    }
}
