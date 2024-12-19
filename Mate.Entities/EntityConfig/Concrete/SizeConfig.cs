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

            builder.HasData(new Size() { Id = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", SizeNumber = 8, CreatedAt = DateTime.Now });
            builder.HasData(new Size() { Id = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", SizeNumber = 10, CreatedAt = DateTime.Now });
            builder.HasData(new Size() { Id = "11ebdd3a-f75a-4d85-9916-220874cf8af9", SizeNumber = 12, CreatedAt = DateTime.Now });
            builder.HasData(new Size() { Id = "152002fb-d980-4750-a70a-7b5d0bdac9e4", SizeNumber = 14, CreatedAt = DateTime.Now });


        }
    }
}
