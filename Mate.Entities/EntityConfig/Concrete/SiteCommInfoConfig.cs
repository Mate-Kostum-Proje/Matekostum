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

            builder.Property(p => p.GSM1).HasMaxLength(300).IsRequired();
            builder.HasIndex(p => p.GSM1).IsUnique();

            builder.Property(p => p.GSM2).HasMaxLength(300).IsRequired();
            builder.HasIndex(p => p.GSM2).IsUnique();

            builder.Property(p => p.GSM3).HasMaxLength(300).IsRequired();
            builder.HasIndex(p => p.GSM3).IsUnique();

            builder.Property(p => p.Email).HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Email).IsUnique();

            builder.Property(p => p.WorkingHours).HasMaxLength(300).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(300).IsRequired();
            builder.Property(p => p.Transportation).HasMaxLength(300).IsRequired();

            builder.Property(p => p.SocialMedias).HasMaxLength(300).IsRequired();

            builder.HasData(new SiteCommInfo()
            {
                Email = "matekostum@gmail.com",
                Phone = "0212 549 77 34",
                GSM1 = "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem",
                GSM2 = "İmalat \r\n\r\n 0532 321 64 97 – İsmail",
                GSM3 = "0532 267 23 86 – Ergun",
                WorkingHours = "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00",
                SocialMedias = "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum",
                Address = "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL",
                Transportation = "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı",
                CreatedAt = DateTime.Now
            });

        }
    }
}
