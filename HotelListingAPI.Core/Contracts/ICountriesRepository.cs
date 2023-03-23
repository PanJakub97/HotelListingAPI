using HotelListingAPI.Data;
using HotelListingAPI.Core.Models.Country;

namespace HotelListingAPI.Core.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
