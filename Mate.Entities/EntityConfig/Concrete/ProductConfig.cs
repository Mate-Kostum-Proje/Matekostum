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
            builder.Property(x => x.UnitPriceForSale).IsRequired().HasMaxLength(100000);
            builder.Property(x => x.UnitPriceForRent).HasMaxLength(100000);
            builder.Property(x => x.IsSale).IsRequired();
            builder.Property(x => x.Gender).HasMaxLength(20);


            builder.HasOne(p => p.ProductCategories).WithMany(p => p.Products).HasForeignKey(p => p.ProductCategoryId).IsRequired();
            builder.HasOne(p => p.ProductRegions).WithMany(p => p.Products).HasForeignKey(p => p.ProductRegionId).IsRequired();
            builder.HasOne(p => p.ProductSubRegions).WithMany(p => p.Products).HasForeignKey(p => p.ProductSubRegionId).IsRequired();

            //UnitPriceForsale = 1500,
            //ÇOCUK
            //1.HALK OYUNLARI ÇOCUK
            builder.HasData(new Product() { ProductName = "Aşuk Maşuk", IsAdult = false, Size = 14, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ADIYAMAN", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "GÜNEYDOGU ANADOLU", ProductSubRegionId = "ADIYAMAN", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ANKARA", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "İÇ ANADOLU", ProductSubRegionId = "ANKARA", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ARTVİN", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KARADENİZ", ProductSubRegionId = "ARTVİN", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ARTVİN İŞLİ", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KARADENİZ", ProductSubRegionId = "ARTVİN", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BİLECİK", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "MARMARA", ProductSubRegionId = "BİLECİK", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BİTLİS E", Gender = false, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "DOGU ANADOLU", ProductSubRegionId = "BİTLİS", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BİTLİS K", Gender=true,IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "DOGU ANADOLU", ProductSubRegionId = "BİTLİS", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BOLU İŞLİ", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "MARMARA", ProductSubRegionId = "BOLU", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BOLU SADE", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "MARMARA", ProductSubRegionId = "BOLU", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "GAZİANTEP K", Gender = true, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "GÜNEYDOGU ANADOLU", ProductSubRegionId = "GAZİANTEP", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "DİYARBAKIR", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "GÜNEYDOGU ANADOLU", ProductSubRegionId = "DİYARBAKIR", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ELAZIĞ", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "DOGU ANADOLU", ProductSubRegionId = "ELAZIĞ", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "GAZİANTEP K", Gender = true, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "GÜNEYDOGU ANADOLU", ProductSubRegionId = "GAZİANTEP", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "GAZİANTEP E", Gender = false, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "GÜNEYDOGU ANADOLU", ProductSubRegionId = "GAZİANTEP", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "HALAY KIRMIZI", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun",  ProductSubRegionId = "HALAY", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "HALAY SİYAH", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductSubRegionId = "HALAY", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "KARADENİZ", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KARADENİZ",  CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "KAFKAS KIRMIZI", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KAFKAS", ProductSubRegionId = "KAFKAS", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "KAFKAS MOR", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "KAFKAS", ProductSubRegionId = "KAFKAS", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "SİLİFKE", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "MARMARA", ProductSubRegionId = "SİLİFKE", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TEKE E", Gender = false, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "AKDENİZ", ProductSubRegionId = "TEKE", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TEKE YEŞİL", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "AKDENİZ", ProductSubRegionId = "TEKE", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TEKE PEMBE", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "AKDENİZ", ProductSubRegionId = "TEKE", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TRAKYA", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "TRAKYA", /*ProductSubRegionId = " ",*/ CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TRAKYA BORDO", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "TRAKYA", /*ProductSubRegionId = " ",*/ CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TRAKYA PEMBE", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "TRAKYA", /*ProductSubRegionId = " ",*/ CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "VAN", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "DOGU ANADOLU", ProductSubRegionId = "VAN", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK E", Gender = false, IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "EGE", ProductSubRegionId = "ZEYBEK", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK İŞLİ", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "EGE", ProductSubRegionId = "ZEYBEK", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK MOR", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "EGE", ProductSubRegionId = "ZEYBEK", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK BORDO", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "EGE", ProductSubRegionId = "ZEYBEK", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK KIRMIZI", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "2halkoyun", ProductRegionId = "EGE", ProductSubRegionId = "ZEYBEK", CreatedAt = DateTime.Now });

            //3. STİLİZE DANS ÇOCUK

            builder.HasData(new Product() { ProductName = "ÇAÇA", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", /*ProductRegionId = " ", ProductSubRegionId = "",*/ CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ÇİFTETELLİ PEMBE", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "FRAK", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "GREASE", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "HİNT", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "İSPANYOL", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans",  CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ROMAN FUŞYA", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", ProductSubRegionId = "ROMAN", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ROMAN KIRMIZI", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", ProductSubRegionId = "ROMAN", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ROMAN KIR(1)", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", ProductSubRegionId = "ROMAN", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ROMAN MOR", IsAdult = false, Size = 8, IsSale = false, UnitPriceForRent = 1500, ProductCategoryId = "4dans", ProductSubRegionId = "ROMAN", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "SALSA", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "SALSA E", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "4dans", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "STİLİZE KIRMIZI", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "4dans", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "STİLİZE MOR", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "4dans", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "STİLİZE PEMBE", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "4dans", ProductRegionId = "", CreatedAt = DateTime.Now });


            builder.HasData(new Product() { ProductName = "    ", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });//BOŞLUK ?
            builder.HasData(new Product() { ProductName = "SALSA", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "4dans", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "SALSA E", Gender = false, IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "4dans", ProductRegionId = "", CreatedAt = DateTime.Now });




        }
    }
}
