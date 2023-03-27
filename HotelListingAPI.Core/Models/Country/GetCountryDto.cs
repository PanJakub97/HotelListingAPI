using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Core.Models.Country
{
    public class GetCountryDto : BaseCountryDto, IBaseDto
    {
        public int Id { get; set; }
    }

}
