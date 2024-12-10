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
            builder.Property(x => x.UnitPiceForRent).HasMaxLength(100000);

            builder.HasOne(p => p.ProductCategories).WithMany(p => p.Products).HasForeignKey(p => p.ProductCategoryId).IsRequired();
            builder.HasOne(p => p.ProductRegions).WithMany(p => p.Products).HasForeignKey(p => p.ProductRegionId).IsRequired();

            //ÇOCUK
            //1.HALK OYUNLARI
            //builder.HasData(new Product() { ProductName = "Aşuk Maşuk", IsAdult = true, Size = 14, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ADIYAMAN", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ANKARA", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ARTVİN", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ARTVİN İŞLİ", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BİLECİK", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BİTLİS E", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BİTLİS K", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BOLU İŞLİ", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "BOLU SADE", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "GAZİANTEP K", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "DİYARBAKIR", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ELAZIĞ", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "GAZİANTEP K", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "GAZİANTEP E", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "HALAY KIRMIZI", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "HALAY SİYAH", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "KARADENİZ", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "KAFKAS KIRMIZI", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "KAFKAS MOR", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "SİLİFKE", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TEKE E", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TEKE YEŞİL", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TEKE PEMBE", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TRAKYA", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TRAKYA BORDO", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "TRAKYA PEMBE", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "VAN", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK E", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK İŞLİ", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK MOR", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK BORDO", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ZEYBEK KIRMIZI", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            
            //3. STİLİZE DANS
            
            builder.HasData(new Product() { ProductName = "ÇAÇA", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ÇİFTETELLİ PEMBE", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "FRAK", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "GREASE", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "HİNT", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "İSPANYOL", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ROMAN FUŞYA", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ROMAN KIRMIZI", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ROMAN KIR(1)", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "ROMAN MOR", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "SALSA", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "SALSA E", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "STİLİZE KIRMIZI", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "STİLİZE MOR", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "STİLİZE PEMBE", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            
            
            builder.HasData(new Product() { ProductName = "    ", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "SALSA", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });
            builder.HasData(new Product() { ProductName = "SALSA E", IsAdult = true, Size = 8, UnitPriceForSale = 1500, ProductCategoryId = "", ProductRegionId = "", CreatedAt = DateTime.Now });




        }
    }
}
