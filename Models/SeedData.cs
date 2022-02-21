using AjimaExploreTravel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace AjimaExploreTravel.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AjimaExploreTravelContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AjimaExploreTravelContext>>()))
            {
                // Look for any movies.
                if (context.Travel.Any())
                {
                    return;   // DB has been seeded
                }

                context.Travel.AddRange(
                    new Travel
                    {
                        TravelTitle = "When Harry Met Sally",
                        BookDate = DateTime.Parse("1989-2-12"),
                        HotelAddress = "Romantic Comedy",
                        HotelPrice = 7.99M
                    },

                    new Travel
                    {
                        TravelTitle = "Ghostbusters ",
                        BookDate = DateTime.Parse("1984-3-13"),
                        HotelAddress = "Comedy",
                        HotelPrice = 8.99M
                    },

                    new Travel
                    {
                        TravelTitle = "Ghostbusters 2",
                        BookDate = DateTime.Parse("1986-2-23"),
                        HotelAddress = "Comedy",
                        HotelPrice = 9.99M
                    },

                    new Travel
                    {
                        TravelTitle = "Rio Bravo",
                        BookDate = DateTime.Parse("1959-4-15"),
                        HotelAddress= "Western",
                        HotelPrice = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
    

