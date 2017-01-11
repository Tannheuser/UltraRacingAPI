using System;
using System.Linq;

namespace UltraRacing.Core.Models
{
    public class RacingSeeder
    {
        private readonly RacingContext _context;

        public RacingSeeder(RacingContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Races.Any())
            {
                _context.Races.AddRange(
                    new Race {Title = "Daytona Thunderdome", ImageUrl = "/images/races/daytona_thunderdome.jpg", Description = "Race through the ruins of an ancient Florida battle arena.", Price = 3200, StartDate = new DateTime(2017, 02, 10, 17, 0, 0)},
                    new Race {Title = "San Francisco Ruins", ImageUrl = "/images/races/san_francisco_ruins.jpg", Description = "Drift down the streets of a city almost sunk under the ocean.", Price = 4700, StartDate = new DateTime(2017, 02, 21, 23, 0, 0)},
                    new Race {Title = "New York City Skyline", ImageUrl = "/images/races/new_york_city_skyline.jpg", Description = "Fly between buildings in the electronic sky.", Price = 3200, StartDate = new DateTime(2017, 04, 03, 0, 0, 0)}
                );

                _context.SaveChanges();
            }
        }
    }
}