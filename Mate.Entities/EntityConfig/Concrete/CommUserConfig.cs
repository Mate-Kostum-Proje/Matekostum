using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class CommUserConfig : BaseConfig<CommUser>
    {
        public override void Configure(EntityTypeBuilder<CommUser> builder)
        {
            base.Configure(builder);
        }
    }
}
