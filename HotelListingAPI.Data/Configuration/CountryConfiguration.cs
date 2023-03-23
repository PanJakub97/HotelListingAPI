using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            //builder.ToTable("");
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Poland",
                    ShortName = "POL",
                },
                new Country
                {
                    Id = 2,
                    Name = "Jamaica",
                    ShortName = "JM",
                },
                new Country
                {
                    Id = 3,
                    Name = "Bahamas",
                    ShortName = "BS",
                },
                new Country
                {
                    Id = 4,
                    Name = "Dominicana",
                    ShortName = "DOM",
                }
            );
        }
    }
}
