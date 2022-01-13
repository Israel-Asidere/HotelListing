using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Nigeria",
                    ShortName = "NG"
                },
                new Country
                {
                    Id = 3,
                    Name = "Bahamas",
                    ShortName = "BS"
                }
                );
            builder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Sandals Resorts and Spa",
                   Address = "Negril",
                   CountryId = 1,
                   Rating = 4.5
               },
                new Hotel
                {
                    Id = 2,
                    Name = "Transcorp Resorts and Spa",
                    Address = "Abuja",
                    CountryId = 2,
                    Rating = 4.5
                },
                 new Hotel
                 {
                     Id = 3,
                     Name = "Grand Palldium",
                     Address = "George Town",
                     CountryId = 3,
                     Rating = 4.5
                 }


               );
        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
