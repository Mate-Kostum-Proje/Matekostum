using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class MainMenuConfig : BaseConfig<MainMenu>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MainMenu> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.MenuName).HasMaxLength(50);
            builder.Property(p => p.ActionName).HasMaxLength(50);
            builder.Property(p => p.ControllerName).HasMaxLength(50);
            builder.Property(p => p.AreaName).HasMaxLength(50);
            builder.Property(p => p.CssName).HasMaxLength(500);
            builder.Property(p => p.IconName).HasMaxLength(500);

            builder.HasData(new MainMenu //İlerde değişecek!!!!!!!!!!!!!!!
            {
                Id = "Home",
                MenuName = "Home",
                ControllerName = "Home",
                ActionName = "Index",
                ClassName = "bi bi-caret-right-fill",
                CreatedAt = DateTime.Now,
                CssName = "",
                RoleId = 1

            },
             new MainMenu
             {
                 Id = "About",
                 MenuName = "About",
                 ControllerName = "Home",
                 ActionName = "",
                 ClassName = "bi bi-caret-right-fill",
                 CreatedAt = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
             new MainMenu
             {
                 Id = "ProductRent",
                 MenuName = "ProductRent",
                 ControllerName = "Home",
                 ActionName = "ProductRent",
                 ClassName = "bi bi-caret-right-fill",
                 CreatedAt = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
             new MainMenu
             {
                 Id = "ProductSale",
                 MenuName = "ProductSale",
                 ControllerName = "Home",
                 ActionName = "ProductSale",
                 //AreaName = "Admin",
                 ClassName = "bi bi-caret-right-fill",
                 CreatedAt = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
             new MainMenu
             {
                 Id = "Galery",
                 MenuName = "Galery",
                 ControllerName = "Home",
                 ActionName = "Galery",
                 ClassName = "bi bi-caret-right-fill",
                 CreatedAt = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
             new MainMenu
             {
                 Id = "Communication",
                 MenuName = "Communication",
                 ControllerName = "Home",
                 ActionName = "Communication",
                 ClassName = "bi bi-caret-right-fill",
                 CreatedAt = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             }
             );
        }
    }
}
