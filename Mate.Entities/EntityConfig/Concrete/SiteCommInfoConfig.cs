using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class SiteCommInfoConfig : BaseConfig<SiteCommInfo>
    {
        public override void Configure(EntityTypeBuilder<SiteCommInfo> builder)
        {
            base.Configure(builder);
        }
    }
}
