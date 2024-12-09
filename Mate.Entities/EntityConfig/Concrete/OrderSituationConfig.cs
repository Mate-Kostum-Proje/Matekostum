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
        }
    }
}
