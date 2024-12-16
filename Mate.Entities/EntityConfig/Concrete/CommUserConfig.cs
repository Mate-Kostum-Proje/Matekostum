using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
	public class CommUserConfig : BaseConfig<CommUser>
	{
		public override void Configure(EntityTypeBuilder<CommUser> builder)
		{
			base.Configure(builder);
			builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
			builder.Property(p => p.Subject).IsRequired().HasMaxLength(100);
			builder.Property(p => p.Email).IsRequired().HasMaxLength(50);
			builder.Property(p => p.Message).IsRequired().HasMaxLength(500);
		}
	}
}
