using Mate.BL.Abstract;
using Mate.BL.Concrete;

namespace Mate.MVC.Extensions
{
    public static class MateExtension
    {
        public static IServiceCollection AddMateProje(this IServiceCollection services)
        {

            services.AddScoped(typeof(IManager<>), typeof(Manager<>));

            return services;
        }
    }
}