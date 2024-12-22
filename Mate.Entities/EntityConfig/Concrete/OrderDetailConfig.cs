using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class OrderDetailConfig : BaseConfig<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.Orders).WithMany(p => p.OrderDetails).HasForeignKey(p => p.OrderId).IsRequired();
            builder.HasOne(p => p.Products).WithMany(p => p.OrderDetails).HasForeignKey(p => p.ProductId).IsRequired();
            //builder.Property(p => p.Amount).HasConversion(p => p.CompareTo(Product)))  //TODO 
            builder.Property(x => x.UnitPriceForSale).HasMaxLength(100000);
            builder.Property(x => x.UnitPiceForRent).HasMaxLength(100000);
            builder.Property(x => x.ProductSize).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Amount).IsRequired().HasMaxLength(500);


        }
    }
}
