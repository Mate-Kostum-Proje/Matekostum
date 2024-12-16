using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
	public class FotoDesignConfig : BaseConfig<FotoDesign>
	{
		public override void Configure(EntityTypeBuilder<FotoDesign> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
			builder.Property(x => x.PhotoPath).IsRequired();

			builder.HasData(new FotoDesign() { Name = "STİLİZE E2", PhotoPath = "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "ÇİFTETELLİ MAVİ", PhotoPath = "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "ROMAN T", PhotoPath = "/databaseimg/tasarım/tasarımROMAN-T.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "İSPANYOL K", PhotoPath = "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "YENİÇERİ", PhotoPath = "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "MAŞUK", PhotoPath = "/databaseimg/tasarım/tasarımMAŞUK.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "SALSA K", PhotoPath = "/databaseimg/tasarım/tasarımSALSA-K.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "ŞAMAN", PhotoPath = "/databaseimg/tasarım/tasarımŞAMAN.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "OSMANLI", PhotoPath = "/databaseimg/tasarım/tasarımOSMANLI.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "STİLİZE E", PhotoPath = "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "AŞUK", PhotoPath = "/databaseimg/tasarım/tasarımAŞUK.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoDesign() { Name = "FLAMENKO", PhotoPath = "/databaseimg/tasarım/tasarımFLAMENKO.jpg", CreatedAt = DateTime.Now });

		}
	}
}
