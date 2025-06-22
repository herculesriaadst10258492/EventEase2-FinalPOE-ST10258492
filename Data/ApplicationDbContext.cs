using Microsoft.EntityFrameworkCore;
using EventEase2.Models;

namespace EventEase2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; } = default!;
        public DbSet<Event> Events { get; set; } = default!;
        public DbSet<Booking> Bookings { get; set; } = default!;
    }
}
