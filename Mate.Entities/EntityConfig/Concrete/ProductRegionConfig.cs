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
        }
    }
}
