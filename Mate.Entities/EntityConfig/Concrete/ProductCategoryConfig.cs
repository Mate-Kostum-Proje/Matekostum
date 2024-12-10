using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class ProductCategoryConfig : BaseConfig<ProductCategory>
    {
        public override void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();

            builder.HasData(new ProductCategory() { Name = " ", CreatedAt = DateTime.Now });
            //KOSTÜM KİRALAMA
            //1.HALKOYUNLARI
            //ÇOCUKYÖRESELKIYAFETLERİ
            builder.HasData(new ProductCategory() { Name = " ADIYAMAN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ANKARA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ARTVİN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ARTVİN İŞLİ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BİLECİK", CreatedAt = DateTime.Now });           
            builder.HasData(new ProductCategory() { Name = "BİTLİS E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BİTLİS K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BOLU İŞLİ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BOLU SADE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GAZİANTEP K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "DİYARBAKIR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ELAZIĞ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GAZİANTEP K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GAZİANTEP E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "HALAY KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "HALAY SİYAH", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KARADENİZ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KAFKAS KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KAFKAS MOR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "SİLİFKE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TEKE E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TEKE YEŞİL", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TEKE PEMBE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRAKYA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRAKYA BORDO", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRAKYA PEMBE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "VAN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK İŞLİ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK MOR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK BORDO", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK KIRMIZI", CreatedAt = DateTime.Now });




            //YETİSKİNYÖRESELKIYAFETLERİ

            builder.HasData(new ProductCategory() { Name = "ADIYAMAN E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ADIYAMAN K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ANKARA E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ARTVİN E2", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ARTVİN K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BİLECİK K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BİTLİS BEYAZ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BİTLİS MAVİ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BOLU K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BURDUR E2", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "BURDUR K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "DİYARBAKIR E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "DİYARBAKIR K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GAZİANTEP E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GAZİANTEP K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GİRESUN E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GİRESUN K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "HAKKARİ K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KAFKAS E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KAFKAS K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "SİLİFKE E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "SİLİFKE K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRAKYA KIRMIZI KADİFE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRAKYA KREM", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRAKYA MAVİ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRAKYA MOR MONORAY", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRAKYA PEMBE K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRAKYA PEMBE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRABZON E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRABZON K İŞLİK ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRABZON MOR İŞLİK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRABZON MOR YELEK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TRABZON PEMBE YELEK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ÜSKÜP E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ÜSKÜP K BORDO", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "VAN BEYAZ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "VAN K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "VAN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK AÇIK E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK AĞIR E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK BORDO", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK EŞKİYA E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK KOYU E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK EŞKİYA E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK KOYU E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK MOR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK MUĞLA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ZEYBEK PEMBE", CreatedAt = DateTime.Now });

            //2.BİNDALLI VE KINA
            // KİRALIK KINA KIYAFETLERİ
            builder.HasData(new ProductCategory() { Name = "GELENEKSEL KAFTAN BORDO", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GELENEKSEL KAFTAN KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GELENEKSEL KAFTAN KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GELENEKSEL KAFTAN KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GELENEKSEL KAFTAN MOR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GELENEKSEL KAFTAN MÜRDÜM", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GELENEKSEL KAFTAN PEMBE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GELENEKSEL KAFTAN YEŞİL", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ BORDO", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ GRİ-SİYAH", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ KIRMIZI-N2", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ LACİVERT", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ LACİVERT-N2", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ LACİVERT-N3", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ PEMBE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ PEMBE-N2", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ ÜSKÜP-N2", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KINA KIYAFETİ YEŞİL", CreatedAt = DateTime.Now });

            //3. STİLİZE DANS
            //Kostüm Kiralama - Stilize Dans,Salsa ve Roman Kostümleri
            //YETİŞKİN STİLİZE DANS ve ROMAN KOSTÜMLERİ
            builder.HasData(new ProductCategory() { Name = "AŞUK MAŞUK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ÇİFTETELLİ BEYAZ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "LİRİK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ROMAN FUŞYA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ROMAN KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ROMAN PEMBE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ROMAN RENKLİ ETEK", CreatedAt = DateTime.Now }); 
            builder.HasData(new ProductCategory() { Name = "ROMAN TURUNCU", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ROMAN YEŞİL", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE KIRMIZI E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE KIRMIZI K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE MAVİ E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE MAVİ K", CreatedAt = DateTime.Now });

            //ÇOCUK STİLİZE DANS ve ROMAN KOSTÜMLERİ
            builder.HasData(new ProductCategory() { Name = "ÇAÇA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ÇİFTETELLİ PEMBE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "FRAK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "GREASE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "HİNT", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "İSPANYOL", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ROMAN FUŞYA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ROMAN KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ROMAN KIR(1)", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ROMAN MOR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "SALSA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "SALSA E", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE MOR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE PEMBE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE PEMBE", CreatedAt = DateTime.Now });

            //4. ROND TÖREN
            // Kiralık Yıl Sonu Gösteri Kıyafetleri - Asker Kıyafeti Kiralama-Çanakkale Askeri Kıyafeti
            //KİRALIK ÇOCUK GÖSTERİ ve TÖREN KOSTÜMLERİ
            builder.HasData(new ProductCategory() { Name = "ARI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ASKER", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ÇAÇA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ÇİÇEK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "FARE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "HACİVAT KARAGÖZ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "İSPANYOL", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KATİBİM", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KIRMIZI BAŞLIKLI KIZ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "MEHTER", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "MEZUNİYET", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "NASREDDİN HOCA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "NOEL BABA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ÖRDEK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "PADİŞAH", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "PAMUK PRENSES", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "PALYAÇO", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "SALSA K", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE KIRMIZI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "STİLİZE SARI", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "ŞİRİNLER", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "TAVŞAN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "YENİÇERİ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "SEMAZEN", CreatedAt = DateTime.Now });

            // KİRALIK YETİŞKİN GÖSTERİ ve TÖREN KOSTÜMLERİ
            builder.HasData(new ProductCategory() { Name = "ÇANAKKALE ASKER", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "FERACE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "HACİVAT", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "KARAGÖZ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "MANASTIR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "MEHTER", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "NOEL ANNE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "NOEL BABA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "PADİŞAH", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "SEMAZEN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductCategory() { Name = "YENİÇERİ", CreatedAt = DateTime.Now });


            //KOSTÜM SATIŞ


        }
    }
}
