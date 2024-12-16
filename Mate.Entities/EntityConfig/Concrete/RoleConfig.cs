using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
	public class RoleConfig : BaseConfig<Role>
	{
		public override void Configure(EntityTypeBuilder<Role> builder)
		{
			base.Configure(builder);
			builder.Property(p => p.RoleName).HasMaxLength(50);
			builder.HasIndex(p => p.RoleName).IsUnique();
			builder.Property(r => r.Id).ValueGeneratedNever();

			builder.HasData(new Role() { Id = "ad", RoleName = "Admin", CreatedAt = DateTime.Now });
			builder.HasData(new Role() { Id = "us", RoleName = "User", CreatedAt = DateTime.Now });
		}
	}

}