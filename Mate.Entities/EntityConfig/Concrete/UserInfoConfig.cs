using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class UserInfoConfig : BaseConfig<UserInfo>
    {
        public override void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SurName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.TcNo).IsRequired().HasMaxLength(11);
            builder.HasIndex(p => p.TcNo).IsUnique();
            builder.Property(x => x.GSM).IsRequired().HasMaxLength(50);
            builder.HasIndex(p => p.GSM).IsUnique();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.HasIndex(p => p.Email).IsUnique();
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(300);
            builder.Property(x => x.City).IsRequired().HasMaxLength(20);
            builder.Property(x => x.District).IsRequired().HasMaxLength(20);



            // builder.HasData(new UserInfo() { Name = "İdil", SurName = "Erdoğan", TcNo = "12260515552" });
        }
    }
}
