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

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            //3. STİLİZE DANS
            //Kostüm Kiralama - Stilize Dans,Salsa ve Roman Kostümleri
            //YETİŞKİN STİLİZE DANS ve ROMAN KOSTÜMLERİ
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });





            // KİRALIK YETİŞKİN GÖSTERİ ve TÖREN KOSTÜMLERİ   ////BU KISMIN FOTOLARI YETİŞKİN ROND TÖREN KLASÖRÜNDE
            //YETİŞKİN 4. ROND TÖREN
            // Kiralık Yıl Sonu Gösteri Kıyafetleri - Asker Kıyafeti Kiralama-Çanakkale Askeri Kıyafeti
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-ÇANAKKALEASKERİ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-ÇANAKKALEASKERİ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-ÇANAKKALEASKERİ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-ÇANAKKALEASKERİ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-FERACE-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-FERACE-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-FERACE-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-FERACE-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-HACİVAT-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-HACİVAT-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-HACİVAT-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-HACİVAT-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-KARAGÖZ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-KARAGÖZ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-KARAGÖZ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-KARAGÖZ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-MANASTIR-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-MANASTIR-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-MANASTIR-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-MANASTIR-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-MEHTER-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-MEHTER-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-MEHTER-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-MEHTER-YETİŞKİNKİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-NOELANNE-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-NOELANNE-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-NOELANNE-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-NOELANNE-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-NOELBABA-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-NOELBABA-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-NOELBABA-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-NOELBABA-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-PADİŞAH-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-PADİŞAH-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-PADİŞAH-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-PADİŞAH-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-SEMAZEN-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-SEMAZEN-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-SEMAZEN-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-SEMAZEN-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-YENİÇERİ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-YENİÇERİ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-YENİÇERİ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/ROND-YENİÇERİ-YETİŞKİN-KİRALIK.jpg", SizeNumber = 14, SizeAmount = 7 });


            //***********************SATILIK*************************

            //HALK OYUNLARI
            //AKDENİZ,EGE,DOĞU ANADOLU,GÜNEY DOĞU,İÇ ANADOLU,KAFKAS,KARADENİZ,MARMARA,TRAKYA
            //AKDENİZ
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AŞUKMAŞUK-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AŞUKMAŞUK-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AŞUKMAŞUK-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AŞUKMAŞUK-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANAMUR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANAMUR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANAMUR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANAMUR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANAMUR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANAMUR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANAMUR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANAMUR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURDUR-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUT-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUT-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUT-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUT-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUT-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUT-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUT-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUT-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-SİLİFKE-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            //EGE
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AFYON-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AFYON-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AFYON-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AFYON-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AYDIN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AYDIN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AYDIN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AYDIN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AYDIN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AYDIN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AYDIN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AYDIN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALE-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALE-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALE-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALE-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALE-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALE-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALE-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALE-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALEPOMAK-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALEPOMAK-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALEPOMAK-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇANAKKALEPOMAK-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DENİZLİ-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DENİZLİ-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DENİZLİ-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DENİZLİ-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DENİZLİ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DENİZLİ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DENİZLİ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DENİZLİ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRAÇIK-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRAÇIK-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRAÇIK-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRAÇIK-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRFUŞYA-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRFUŞYA-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRFUŞYA-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRFUŞYA-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRKOYU-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRKOYU-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRKOYU-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRKOYU-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRKOYU2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRKOYU2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRKOYU2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRKOYU2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRMÜRDÜM-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRMÜRDÜM-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRMÜRDÜM-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRMÜRDÜM-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRMOR-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRMOR-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRMOR-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-İZMİRMOR-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUĞLA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUĞLA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUĞLA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MUĞLA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            //DOGU ANADOLU

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRIBEYAZ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRIBEYAZ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRIBEYAZ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRIBEYAZ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRI-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRI-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRI-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRI-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRIKADİFE-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRIKADİFE-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRIKADİFE-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-AĞRIKADİFE-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARDAHAN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARDAHAN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARDAHAN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARDAHAN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARDAHAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARDAHAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARDAHAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARDAHAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ERZİNCAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ERZİNCAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ERZİNCAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ERZİNCAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ERZURUM-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ERZURUM-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ERZURUM-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ERZURUM-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-HAKKARİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-HAKKARİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-HAKKARİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-HAKKARİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANLACİVERT-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANLACİVERT-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANLACİVERT-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-VANLACİVERT-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            //GÜNEYDOGU anadolu

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANAABA-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANAABA-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANAABA-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANAABA-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADANA-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEPABA-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEPABA-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEPABA-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEPABA-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GAZİANTEP-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-URFA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-URFA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-URFA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-URFA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-URFA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-URFA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-URFA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-URFA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });



            //iç anadolu
            
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/", SizeNumber = 8, SizeAmount = 4 }); // Fotoğraf yok ESKİŞEHİR K3
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/", SizeNumber = 10, SizeAmount = 5 }); // Fotoğraf yok
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/", SizeNumber = 12, SizeAmount = 6 }); // Fotoğraf yok
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/", SizeNumber = 14, SizeAmount = 7 }); // Fotoğraf yok

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ESKİŞEHİR-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/", SizeNumber = 8, SizeAmount = 4 }); // Fotoğraf yok SİVAS K
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/", SizeNumber = 10, SizeAmount = 5 }); // Fotoğraf yok
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/", SizeNumber = 12, SizeAmount = 6 }); // Fotoğraf yok
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/", SizeNumber = 14, SizeAmount = 7 }); // Fotoğraf yok

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TOKAT-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TOKAT-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TOKAT-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TOKAT-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TOKAT-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TOKAT-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TOKAT-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TOKAT-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });
        
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-YOZGAT-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-YOZGAT-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-YOZGAT-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-YOZGAT-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });



            //KAFKAS
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇERKES-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇERKES-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇERKES-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÇERKES-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GÜRCÜ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GÜRCÜ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GÜRCÜ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GÜRCÜ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E3-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E3-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E3-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E3-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E4-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E4-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E4-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-E4-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KAFKAS-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });


            //KARADENİZ
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K5-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K5-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K5-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ARTVİN-K5-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZONCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K3-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K4-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K5-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K5-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K5-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRABZON-K5-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });


            //MARMARA
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-E2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BURSA-K2-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });



            //TRAKYA
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BORDOCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BORDOCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BORDOCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BORDOCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BORDOKISAYELEK-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BORDOKISAYELEK-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BORDOKISAYELEK-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-BORDOKISAYELEK-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KIRMIZIRENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KIRMIZIRENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KIRMIZIRENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KIRMIZIRENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KORDONEFK-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KORDONEFK-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KORDONEFK-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-KORDONEFK-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-LASELİFK-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-LASELİFK-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-LASELİFK-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-LASELİFK-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MANASTIRKAFTAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MANASTIRKAFTAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MANASTIRKAFTAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MANASTIRKAFTAN-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MANASTIRYELEK-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MANASTIRYELEK-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MANASTIRYELEK-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MANASTIRYELEK-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORMARAŞİŞİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORMARAŞİŞİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORMARAŞİŞİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORMARAŞİŞİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORRENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORRENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORRENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORRENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORSALTA-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORSALTA-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORSALTA-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORSALTA-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORMONORAY-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORMONORAY-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORMONORAY-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-MORMONORAY-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-PEMBERENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-PEMBERENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-PEMBERENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-PEMBERENKLİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYABEJ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYABEJ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYABEJ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYABEJ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAÇAĞLA-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAÇAĞLA-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAÇAĞLA-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAÇAĞLA-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBEYAZCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBEYAZCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBEYAZCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBEYAZCEPKEN-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBEYAZ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBEYAZ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBEYAZ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPBEYAZ-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPKIRMIZI-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPKIRMIZI-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPKIRMIZI-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPKIRMIZI-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPSİYAH-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPSİYAH-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPSİYAH-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜPSİYAH-K-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-RENKLİSALTA-YETİŞKİN-SATILIK.jpg", SizeNumber = 8, SizeAmount = 4 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-RENKLİSALTA-YETİŞKİN-SATILIK.jpg", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-RENKLİSALTA-YETİŞKİN-SATILIK.jpg", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductPhotoPath = "/databaseimg/HALKOYUN-RENKLİSALTA-YETİŞKİN-SATILIK.jpg", SizeNumber = 14, SizeAmount = 7 });



        }
    }
}
