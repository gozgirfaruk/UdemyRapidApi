using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.UI.Dtos.AppUser;
using HotelProject.UI.Dtos.ServiceDto;
using System.Runtime.CompilerServices;

namespace HotelProject.UI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto,Service>().ReverseMap();
            CreateMap<CreateServiceDto,Service>().ReverseMap();
            CreateMap<UpdateServiceDto,Service>().ReverseMap();

            CreateMap<CreateNewUserDto , AppUser>().ReverseMap();
            CreateMap<LoginUserDto , AppUser>().ReverseMap();
        }
    }
}
