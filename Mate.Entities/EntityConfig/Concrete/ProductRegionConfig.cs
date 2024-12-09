using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class ProductRegionConfig : BaseConfig<ProductRegion>
    {
        public override void Configure(EntityTypeBuilder<ProductRegion> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();



            builder.HasData(new ProductRegion() { Name = " ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductRegion() { Name = "Akdeniz", CreatedAt = DateTime.Now });

        }
    }
}
