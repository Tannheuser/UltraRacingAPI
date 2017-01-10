using Microsoft.EntityFrameworkCore;

namespace UltraRacing.Core.Models
{
    public class RacingContext : DbContext
    {
        public DbSet<Race> Races { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Filename=./racing.db");
            // var connString = "Data source=;Initial catalog=races;user=;password=;MultipleActiveResultSets=true;";
            // optionsBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}