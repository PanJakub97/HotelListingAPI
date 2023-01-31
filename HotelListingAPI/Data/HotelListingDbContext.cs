using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
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

            modelBuilder.Entity<Hotel>().HasData(
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
