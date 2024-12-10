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


            //BÖLGELER(SATILIK KISIMDA)
            builder.HasData(new ProductRegion() { Name = "AKDENİZ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductRegion() { Name = "EGE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductRegion() { Name = "DOGU ANADOLU", CreatedAt = DateTime.Now });
            builder.HasData(new ProductRegion() { Name = "GÜNEYDOGU ANADOLU", CreatedAt = DateTime.Now });
            builder.HasData(new ProductRegion() { Name = "İÇ ANADOLU", CreatedAt = DateTime.Now });
            builder.HasData(new ProductRegion() { Name = "KAFKAS", CreatedAt = DateTime.Now });
            builder.HasData(new ProductRegion() { Name = "KARADENİZ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductRegion() { Name = "MARMARA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductRegion() { Name = "TRAKYA", CreatedAt = DateTime.Now });


        }
    }
}
