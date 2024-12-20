using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
	public class UsersRolesConfig : BaseConfig<UsersRoles>
	{
		public override void Configure(EntityTypeBuilder<UsersRoles> builder)
		{

			builder.HasKey(p => new { p.UserId, p.RoleId });

			builder.HasOne(p => p.Role)
				.WithMany(p => p.Users)
				.HasForeignKey(p => p.RoleId)
				.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);

			builder.HasOne(p => p.UserInfo)
					.WithMany(p => p.Roles)
					.HasForeignKey(p => p.UserId)
					.OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);

		}
	}
}
