using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
	public class ProductConfig : BaseConfig<Product>
	{
		public override void Configure(EntityTypeBuilder<Product> builder)
		{
			base.Configure(builder);

			builder.Property(x => x.ProductName).IsRequired().HasMaxLength(50);
			builder.Property(x => x.Description).HasMaxLength(200);
			builder.Property(x => x.Size).IsRequired().HasMaxLength(50);
			builder.Property(x => x.IsAdult).IsRequired();
			builder.Property(x => x.Amount).IsRequired();

			builder.Property(x => x.UnitPriceForSale).HasMaxLength(100000);
			builder.Property(x => x.UnitPriceForRent).HasMaxLength(100000);
			builder.Property(x => x.IsSale).IsRequired();
			builder.Property(x => x.Gender).HasMaxLength(20);


			builder.HasOne(p => p.ProductCategories).WithMany(p => p.Products).HasForeignKey(p => p.ProductCategoryId).IsRequired();
			builder.HasOne(p => p.ProductRegions).WithMany(p => p.Products).HasForeignKey(p => p.ProductRegionId);
			builder.HasOne(p => p.ProductSubRegions).WithMany(p => p.Products).HasForeignKey(p => p.ProductSubRegionId);

			//UnitPriceForsale = 1500,
			//ÇOCUK
			//1.HALK OYUNLARI ÇOCUK

			builder.HasData(new Product() { ProductName = "ADIYAMAN", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "GÜNEYDOGU ANADOLU", ProductSubRegionId = "ADIYAMAN", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "ANKARA", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "İÇ ANADOLU", ProductSubRegionId = "ANKARA", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "ARTVİN", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KARADENİZ", ProductSubRegionId = "ARTVİN", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "ARTVİN İŞLİ", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KARADENİZ", ProductSubRegionId = "ARTVİN", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "BİLECİK", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "MARMARA", ProductSubRegionId = "BİLECİK", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "BİTLİS E", Amount = 10, Gender = false, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "DOGU ANADOLU", ProductSubRegionId = "BİTLİS", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "BİTLİS K", Amount = 10, Gender = true, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "DOGU ANADOLU", ProductSubRegionId = "BİTLİS", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "BOLU İŞLİ", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "MARMARA", ProductSubRegionId = "BOLU", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "BOLU SADE", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "MARMARA", ProductSubRegionId = "BOLU", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "DİYARBAKIR", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "GÜNEYDOGU ANADOLU", ProductSubRegionId = "DİYARBAKIR", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "ELAZIĞ", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "DOGU ANADOLU", ProductSubRegionId = "ELAZIĞ", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "GAZİANTEP K", Amount = 10, Gender = true, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "GÜNEYDOGU ANADOLU", ProductSubRegionId = "GAZİANTEP", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "GAZİANTEP E", Amount = 10, Gender = false, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "GÜNEYDOGU ANADOLU", ProductSubRegionId = "GAZİANTEP", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "HALAY KIRMIZI", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductSubRegionId = "HALAY", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "HALAY SİYAH", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductSubRegionId = "HALAY", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "KARADENİZ", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KARADENİZ", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "KAFKAS KIRMIZI", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KAFKAS", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "KAFKAS MOR", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KAFKAS", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "SİLİFKE", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "MARMARA", ProductSubRegionId = "SİLİFKE", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "TEKE E", Amount = 10, Gender = false, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "AKDENİZ", ProductSubRegionId = "TEKE", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "TEKE YEŞİL", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "AKDENİZ", ProductSubRegionId = "TEKE", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "TEKE PEMBE", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "AKDENİZ", ProductSubRegionId = "TEKE", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "TRAKYA", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "TRAKYA", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "ÜSKÜP", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "TRAKYA", ProductSubRegionId = "ÜSKÜP", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "TRAKYA PEMBE", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "TRAKYA", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "TRAKYA BEYAZ", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "TRAKYA", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "VAN", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "DOGU ANADOLU", ProductSubRegionId = "VAN", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "ZEYBEK BORDO", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "EGE", ProductSubRegionId = "ZEYBEK", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "ZEYBEK E", Amount = 10, Gender = false, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "EGE", ProductSubRegionId = "ZEYBEK", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "ZEYBEK İŞLİ", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "EGE", ProductSubRegionId = "ZEYBEK", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg" });
			builder.HasData(new Product() { ProductName = "ZEYBEK MOR", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "EGE", ProductSubRegionId = "ZEYBEK", CreatedAt = DateTime.Now, PhotoPath = "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg" });



			//3. STİLİZE DANS ÇOCUK

			builder.HasData(new Product() { ProductName = "ÇAÇA", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", /*ProductRegionId = " ", ProductSubRegionId = "",*/ CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "ÇİFTETELLİ PEMBE", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "FRAK", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "GREASE", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "HİNT", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "İSPANYOL", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "ROMAN FUŞYA", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", ProductSubRegionId = "ROMAN", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "ROMAN KIRMIZI", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", ProductSubRegionId = "ROMAN", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "ROMAN KIR(1)", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", ProductSubRegionId = "ROMAN", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "ROMAN MOR", Amount = 10, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", ProductSubRegionId = "ROMAN", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "SALSA", Amount = 10, IsAdult = true, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "1boş", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "SALSA E", Amount = 10, IsAdult = true, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "STİLİZE KIRMIZI", Amount = 10, IsAdult = true, IsSale = false, Size = 8, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "STİLİZE MOR", Amount = 10, IsAdult = true, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "STİLİZE PEMBE", Amount = 10, IsAdult = true, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });


			//builder.HasData(new Product() { ProductName = "    ", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });//BOŞLUK ?
			builder.HasData(new Product() { ProductName = "SALSA", Amount = 10, IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
			builder.HasData(new Product() { ProductName = "SALSA E", Amount = 10, Gender = false, IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });


			builder.HasData(new Product() { ProductName = "AŞUK MAŞUK", Amount = 10, IsAdult = true, Size = 14, UnitPriceForSale = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "AKDENİZ", CreatedAt = DateTime.Now });

		}
	}
}
