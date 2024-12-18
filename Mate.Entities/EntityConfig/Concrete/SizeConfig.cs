using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class SizeConfig : BaseConfig<Size>
    {
        public override void Configure(EntityTypeBuilder<Size> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SizeNumber).HasMaxLength(14).IsRequired();

            builder.HasData(new Size() { SizeNumber = 8, CreatedAt = DateTime.Now });
            builder.HasData(new Size() { SizeNumber = 10, CreatedAt = DateTime.Now });
            builder.HasData(new Size() { SizeNumber = 12, CreatedAt = DateTime.Now });
            builder.HasData(new Size() { SizeNumber = 14, CreatedAt = DateTime.Now });


        }
    }
}
