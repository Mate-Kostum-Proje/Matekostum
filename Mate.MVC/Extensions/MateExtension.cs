using System.Security.Claims;
using System.Security.Principal;
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
	public static class IdentityExtension
	{
		public static string GetId(this IIdentity identity)
		{
			ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;

			Claim claim = claimsIdentity.FindFirst(ClaimTypes.SerialNumber);

			return claim.Value;
		}
	}



}