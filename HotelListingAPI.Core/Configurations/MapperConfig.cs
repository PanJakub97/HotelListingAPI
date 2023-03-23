using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Core.Models.Country;
using HotelListingAPI.Core.Models.Hotel;
using HotelListingAPI.Core.Models.Users;
using System.Collections.Generic;

namespace HotelListingAPI.Core.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();

            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
        }
    }
}
