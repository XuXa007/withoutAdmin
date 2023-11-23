using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebApplication7Context(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<WebApplication7Context>>()))
        {
            if (context == null || context.Vehicle == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }
            
            if (context.Vehicle.Any())
            {
                return;   // DB has been seeded
            }

            context.Vehicle.AddRange(
                new Vehicle
                {
                    Id = 1,
                    Make = "some1",
                    Model = "Romantic Comedy",
                    RegistrationNumber = "777"
                },

                new Vehicle
                {
                    Id = 2,
                    Make = "some2",
                    Model = "Mazda",
                    RegistrationNumber = "111"
                });
            context.SaveChanges();
        }
    }
}