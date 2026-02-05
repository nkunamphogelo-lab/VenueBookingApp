using Microsoft.EntityFrameworkCore;
using VenueBookingApp.Models;

namespace VenueBookingApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Venue> Venues { get; set; }
    }
}