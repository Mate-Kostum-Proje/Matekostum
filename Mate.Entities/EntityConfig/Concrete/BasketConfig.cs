using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class BasketConfig : BaseConfig<Basket>
    {
        public override void Configure(EntityTypeBuilder<Basket> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.UserInfos).WithMany(p => p.BasketList).HasForeignKey(p => p.UserId).IsRequired();

        }
    }
}
