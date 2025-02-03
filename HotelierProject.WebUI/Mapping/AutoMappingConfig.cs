using AutoMapper;
using HotelierProject.EntityLayer.Concrete;
using HotelierProject.WebUI.Dtos.AboutDto;
using HotelierProject.WebUI.Dtos.GuestDto;
using HotelierProject.WebUI.Dtos.LoginDto;
using HotelierProject.WebUI.Dtos.RegisterDto;
using HotelierProject.WebUI.Dtos.ServiceDto;
using HotelierProject.WebUI.Dtos.StaffDto;
using HotelierProject.WebUI.Dtos.SubscribeDto;

namespace HotelierProject.WebUI.Mapping
{
    public class AutoMappingConfig:Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<ResultServiceDto,Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultStaffDto, Staffs>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<ApprovedReservationDto,Booking>().ReverseMap();
            CreateMap<ResultGuestDto,Guest>().ReverseMap();

        }
    }
}
