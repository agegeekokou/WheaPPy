using Microsoft.EntityFrameworkCore;
using WheaPPyAPI.Models.Domain;

namespace WheaPPyAPI.Data
{
    public class WheaPPyDbContext : DbContext
    {
        public WheaPPyDbContext(DbContextOptions<WheaPPyDbContext> options) : base(options) 
        {
                
        }

        public DbSet<Location> locations { get; set; }
        public DbSet<WeatherData> WeatherData { get; set; }
        public DbSet<HourlyForecast> HourlyForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
                .HasMany(l => l.WeatherData)
                .WithOne(w => w.Location)
                .HasForeignKey(w => w.LocationId);

            modelBuilder.Entity<Location>()
                .HasMany(l => l.HourlyForecasts)
                .WithOne(h => h.Location)
                .HasForeignKey(h => h.LocationId);
        }
    }
}
