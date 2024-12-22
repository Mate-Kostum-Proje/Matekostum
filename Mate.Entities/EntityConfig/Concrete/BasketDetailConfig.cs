using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class BasketDetailConfig : BaseConfig<BasketDetail>
    {
        public override void Configure(EntityTypeBuilder<BasketDetail> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.Baskets).WithMany(p => p.BasketDetails).HasForeignKey(p => p.BasketId).IsRequired();
            builder.HasOne(p => p.Products).WithMany(p => p.BasketDetails).HasForeignKey(p => p.ProductId).IsRequired();
            //builder.Property(p => p.Amount).HasConversion(p => p.CompareTo(Product)))  //TODO 
            builder.Property(x => x.UnitPriceForSale).HasMaxLength(100000);
            builder.Property(x => x.UnitPiceForRent).HasMaxLength(100000);
            builder.Property(x => x.ProductSize).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Amount).IsRequired().HasMaxLength(500);
            builder.Property(x => x.IsSale).IsRequired();
        }
    }
}
