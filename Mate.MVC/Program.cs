using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using Mate.BL.Abstract;
using Mate.BL.Concrete;
using Mate.DAL.DbContexts;
using Mate.MVC.AutoMapper;
using Mate.MVC.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace Mate.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //DbContext Registiration
            var conn = builder.Configuration.GetConnectionString("MateData");
            builder.Services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(conn));

            builder.Services.AddScoped(typeof(IManager<>), typeof(Manager<>));
            builder.Services.AddScoped<IBasketManager, BasketManager>();
            builder.Services.AddScoped<IOrderManager, OrderManager>();




            builder.Services.AddAutoMapper(p => p.AddProfile<AutoMapperProfile>());

            #region Notify Service Configuration
            builder.Services.AddNotyf(p =>
            {
                p.Position = NotyfPosition.TopCenter;
                p.DurationInSeconds = 7;
                p.IsDismissable = true;
            });
            #endregion

            #region Cookie Base Authentication
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.Cookie.Name = "MySiteCookie";
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/ErisimHatasý";
                options.Cookie.HttpOnly = true; //Taray?c?daki di?er scriptler okuyamas?n diye güvenlik 
                options.Cookie.SameSite = SameSiteMode.Strict; //Ba?ka taray?c?lar taraf?ndan ula??lamas?n diye güvenlik önlemi
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10); //
                options.SlidingExpiration = true; //Herhangi sitede bir hareket oldu?unda süreyi 10 dk uzat?r.


            });
            #endregion

            builder.Services.AddMateProje();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseNotyf();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}