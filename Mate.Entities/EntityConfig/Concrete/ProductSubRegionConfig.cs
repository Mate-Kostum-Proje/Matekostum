﻿using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class ProductSubRegionConfig : BaseConfig<ProductSubRegion>
    {
        public override void Configure(EntityTypeBuilder<ProductSubRegion> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();


            builder.HasData(new ProductSubRegion() { Id = "ADIYAMAN", Name = "ADIYAMAN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "ANKARA", Name = "ANKARA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "ARTVİN", Name = "ARTVİN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "BİLECİK", Name = "BİLECİK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "BİTLİS", Name = "BİTLİS", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "BOLU", Name = "BOLU", CreatedAt = DateTime.Now });
            //ÇAÇA,ÇİFTETELLİ EKLEDİM
            //builder.HasData(new ProductSubRegion() { Id = "ÇAÇA", Name = "ÇAÇA", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "ÇİFTETELLİ", Name = "ÇİFTETELLİ", CreatedAt = DateTime.Now });

            builder.HasData(new ProductSubRegion() { Id = "BURDUR", Name = "BURDUR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "DİYARBAKIR", Name = "DİYARBAKIR", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "ELAZIĞ", Name = "ELAZIĞ", CreatedAt = DateTime.Now });
            //FRAK
            //builder.HasData(new ProductSubRegion() { Id = "FRAK", Name = "FRAK", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "GAZİANTEP", Name = "GAZİANTEP", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "GİRESUN", Name = "GİRESUN", CreatedAt = DateTime.Now });
            //GREASE
            //builder.HasData(new ProductSubRegion() { Id = "GREASE", Name = "GREASE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "HAKKARİ", Name = "HAKKARİ", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "HALAY", Name = "HALAY", CreatedAt = DateTime.Now });
            //KAFKAS EKLEDİM-Ekleme region da zaten var
            //builder.HasData(new ProductSubRegion() { Id = "KAFKAS", Name = "KAFKAS", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "ROMAN", Name = "ROMAN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "SİLİFKE", Name = "SİLİFKE", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "TEKE", Name = "TEKE", CreatedAt = DateTime.Now }); //AKDENİZ BÖLGESİ
            builder.HasData(new ProductSubRegion() { Id = "TRABZON", Name = "TRABZON", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "ÜSKÜP", Name = "ÜSKÜP", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "VAN", Name = "VAN", CreatedAt = DateTime.Now });
            builder.HasData(new ProductSubRegion() { Id = "ZEYBEK", Name = "ZEYBEK", CreatedAt = DateTime.Now });

        }
    }
}
