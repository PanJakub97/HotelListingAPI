using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }


        [ForeignKey(nameof(CountryId))] // "CoutryId" is less safe, when sth will change - VS won't clamor
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
