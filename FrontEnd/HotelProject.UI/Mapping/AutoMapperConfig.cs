using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.UI.Dtos.AboutDto;
using HotelProject.UI.Dtos.AppUser;
using HotelProject.UI.Dtos.BookingDtos;
using HotelProject.UI.Dtos.ContactDtos;
using HotelProject.UI.Dtos.DashboardDtos;
using HotelProject.UI.Dtos.GuestDtos;
using HotelProject.UI.Dtos.NewsLetterDto;
using HotelProject.UI.Dtos.RoomDto;
using HotelProject.UI.Dtos.ServiceDto;
using HotelProject.UI.Dtos.TestimonialDto;
using HotelProject.UI.Dtos.WorkLocation;
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
            CreateMap<ResultAppUserListDto , AppUser>().ReverseMap();

            CreateMap<CreateBookingDto ,Booking>().ReverseMap();
            CreateMap<ResultBookingDto ,Booking>().ReverseMap();
            CreateMap<ApproveStatusDto , Booking>().ReverseMap();

            CreateMap<CreateContactDto , Contact>().ReverseMap();
            CreateMap<InboxContactDto, Contact>().ReverseMap();
            CreateMap<SendmessageDto , SendMessage>().ReverseMap();

            CreateMap<ResultRoomDto, Room>().ReverseMap();  
            CreateMap<UpdateRoomDto , Room>().ReverseMap();
            CreateMap<CreateRoomDto , Room>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();    
            CreateMap<ResultGuestDto, Guest>().ReverseMap();    
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();  
            
            CreateMap<ResultWorklocationDto , WorkLocation>().ReverseMap();
            CreateMap<UpdateLocationDto, WorkLocation>().ReverseMap();
            CreateMap<CreateWorklocationDto , WorkLocation>().ReverseMap();

            CreateMap<LastStaffDto , Staff>().ReverseMap();

           
            
        }
    }
}
