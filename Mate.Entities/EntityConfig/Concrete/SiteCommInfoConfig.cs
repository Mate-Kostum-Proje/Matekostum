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
            builder.Property(p => p.Phone).HasMaxLength(300).IsRequired();
            builder.HasIndex(p => p.Phone).IsUnique();

            builder.Property(p => p.GSM).HasMaxLength(300).IsRequired();
            builder.HasIndex(p => p.GSM).IsUnique();

            builder.Property(p => p.Email).HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Email).IsUnique();

            builder.Property(p => p.WorkingHours).HasMaxLength(300).IsRequired();
            builder.Property(p => p.SocialMedias).HasMaxLength(300).IsRequired();

            builder.HasData(new SiteCommInfo() { Email = "matekostum@gmail.com", Phone = "0212 549 77 34", GSM = "Kiralama WhatsApp İletişim Hattı\r\n\r\n0530 909 11 34 – Erdem\r\n\r\nİmalat\r\n\r\n0532 321 64 97 – İsmail\r\n0532 267 23 86 – Ergun", WorkingHours = "Hafta içi: 09:00 – 17:30\r\n\r\nCumartesi: 09:00 – 13:00", SocialMedias = "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", CreatedAt = DateTime.Now });

        }
    }
}
