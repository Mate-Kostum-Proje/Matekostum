using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class OrderSituationConfig : BaseConfig<OrderSituation>
    {
        public override void Configure(EntityTypeBuilder<OrderSituation> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Situation).HasMaxLength(50);

            builder.HasData(new OrderSituation() { Situation = "Siparişiniz Alındı", CreatedAt = DateTime.Now });
            builder.HasData(new OrderSituation() { Situation = "Siparişiniz Hazırlanıyor", CreatedAt = DateTime.Now });
            builder.HasData(new OrderSituation() { Situation = "Siparişiniz Kargoya verildi", CreatedAt = DateTime.Now });
            builder.HasData(new OrderSituation() { Situation = "Siparişiniz Tamamlandı", CreatedAt = DateTime.Now });

        }
    }
}
