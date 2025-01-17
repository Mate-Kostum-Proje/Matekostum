﻿using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
	public class ProductRegionConfig : BaseConfig<ProductRegion>
	{
		public override void Configure(EntityTypeBuilder<ProductRegion> builder)
		{
			base.Configure(builder);
			builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
			builder.HasIndex(p => p.Name).IsUnique();



			//BÖLGELER(SATILIK KISIMDA)
			builder.HasData(new ProductRegion() { Id = "AKDENİZ", Name = "AKDENİZ", CreatedAt = DateTime.Now });
			builder.HasData(new ProductRegion() { Id = "EGE", Name = "EGE", CreatedAt = DateTime.Now });
			builder.HasData(new ProductRegion() { Id = "DOGU ANADOLU", Name = "DOGU ANADOLU", CreatedAt = DateTime.Now });
			builder.HasData(new ProductRegion() { Id = "GÜNEYDOGU ANADOLU", Name = "GÜNEYDOGU ANADOLU", CreatedAt = DateTime.Now });
			builder.HasData(new ProductRegion() { Id = "İÇ ANADOLU", Name = "İÇ ANADOLU", CreatedAt = DateTime.Now });
			builder.HasData(new ProductRegion() { Id = "KAFKAS", Name = "KAFKAS", CreatedAt = DateTime.Now });
			builder.HasData(new ProductRegion() { Id = "KARADENİZ", Name = "KARADENİZ", CreatedAt = DateTime.Now });
			builder.HasData(new ProductRegion() { Id = "MARMARA", Name = "MARMARA", CreatedAt = DateTime.Now });
			builder.HasData(new ProductRegion() { Id = "TRAKYA", Name = "TRAKYA", CreatedAt = DateTime.Now });


		}
	}
}
