using HotelListingAPI.Data;
using HotelListingAPI.Models.Country;

namespace HotelListingAPI.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
