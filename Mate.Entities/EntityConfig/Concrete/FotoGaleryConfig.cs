using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class FotoGaleryConfig : BaseConfig<FotoGalery>
    {
        public override void Configure(EntityTypeBuilder<FotoGalery> builder)
        {
            base.Configure(builder);
            //TODO
        }
    }
}
