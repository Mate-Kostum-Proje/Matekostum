using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mate.Entities.EntityConfig.Abstract;
using Mate.Entities.Concrete;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class MainMenuConfig:BaseConfig<MainMenu>
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
                ClassName = "far fa-circle nav-icon",
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
                 ClassName = "far fa-circle nav-icon",
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
                 ClassName = "far fa-circle nav-icon",
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
                 ClassName = "far fa-circle nav-icon",
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
                 ClassName = "far fa-circle nav-icon",
                 CreatedAt = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
             new MainMenu
             {
                 Id = "Comm",
                 MenuName = "Comm",
                 ControllerName = "Home",
                 ActionName = "Comm",
                 ClassName = "far fa-circle nav-icon",
                 CreatedAt = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             }
             );
        }
    }  
}
