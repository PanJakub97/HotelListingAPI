using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Gołębiewski",
                    Address = "Karpacz",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Comfort Resort and Spa",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Kambii Resort and Spa",
                    Address = "Bambito",
                    CountryId = 4,
                    Rating = 3
                }
                );
        }
    }
}
