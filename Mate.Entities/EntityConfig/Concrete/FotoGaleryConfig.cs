using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
	public class FotoGaleryConfig : BaseConfig<FotoGalery>
	{
		public override void Configure(EntityTypeBuilder<FotoGalery> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.PhotoPath).IsRequired();

			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriburdur-kostumu.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriGaziantep-Kostum.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriyoresel-kostum.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galerikaradeniz-kostumu.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_2356.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_1958.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_4063.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_1964.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_1962.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_1961.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_1140.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galerigümüşhane-kız.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_0610.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriDMID3671.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galerizeyb.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galerigiresun-2.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_1012.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG-8454.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_8456.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_8455.jpg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriwimg_0201.jpeg", CreatedAt = DateTime.Now });
			builder.HasData(new FotoGalery() { PhotoPath = "/databaseimg/galeri/galeriIMG_2688.jpg", CreatedAt = DateTime.Now });




		}
	}
}
