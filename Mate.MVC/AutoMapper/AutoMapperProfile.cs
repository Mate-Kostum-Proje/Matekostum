using AutoMapper;
using Mate.Entities.Concrete;
using Mate.MVC.Models.VMs;

namespace Mate.MVC.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<UserInsertVM, UserInfo>().ReverseMap();
        }
    }
}