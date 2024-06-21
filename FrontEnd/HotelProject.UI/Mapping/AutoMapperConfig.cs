using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.UI.Dtos.AboutDto;
using HotelProject.UI.Dtos.AppUser;
using HotelProject.UI.Dtos.BookingDtos;
using HotelProject.UI.Dtos.NewsLetterDto;
using HotelProject.UI.Dtos.ServiceDto;
using HotelProject.UI.Dtos.TestimonialDto;
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

            CreateMap<ResultAboutDto , AboutUs>().ReverseMap();
            CreateMap<UpdateAboutDto , AboutUs>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<CreateLetterDto,Subscribe>().ReverseMap();

            CreateMap<CreateNewUserDto , AppUser>().ReverseMap();
            CreateMap<LoginUserDto , AppUser>().ReverseMap();

            CreateMap<CreateBookingDto ,Booking>().ReverseMap();
            CreateMap<ResultBookingDto ,Booking>().ReverseMap();
            CreateMap<ApproveStatusDto , Booking>().ReverseMap();
        }
    }
}
