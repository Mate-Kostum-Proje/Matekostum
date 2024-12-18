using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class ProductSizeConfig : BaseConfig<ProductSize>
    {
        public override void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.Sizes).WithMany(p => p.ProductSizes).HasForeignKey(p => p.SizeId).IsRequired();
            builder.HasOne(p => p.Products).WithMany(p => p.ProductSizes).HasForeignKey(p => p.ProductId).IsRequired();
            builder.HasOne(p => p.Products).WithMany(p => p.ProductSizes).HasForeignKey(p => p.ProductPhotoPath).IsRequired();


            builder.HasIndex(p => p.SizeNumber);
            builder.HasIndex(P => P.ProductPhotoPath).IsUnique();
            builder.HasIndex(P => P.SizeAmount);


            //1.HALK OYUNLARI ÇOCUK

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });


            //3. STİLİZE DANS ÇOCUK



            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });


            //ÇOCUK 4. ROND TÖREN
            // Kiralık Yıl Sonu Gösteri Kıyafetleri - Asker Kıyafeti Kiralama-Çanakkale Askeri Kıyafeti
            //KİRALIK ÇOCUK GÖSTERİ ve TÖREN KOSTÜMLERİ


            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÇAÇAÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÇAÇAÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÇAÇAÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÇAÇAÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDİSPANYOLÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDİSPANYOLÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDİSPANYOLÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDİSPANYOLÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSTİLİZESARIÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSTİLİZESARIÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSTİLİZESARIÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDSTİLİZESARIÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });


            ////YETİŞKİN KİRALIK
            ////1.HALK OYUNLARI YETİŞKİN
            ////YETİSKİNYÖRESELKIYAFETLERİ

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });


            //2.BİNDALLI VE KINA YETİŞKİN


            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

        }
    }
}
