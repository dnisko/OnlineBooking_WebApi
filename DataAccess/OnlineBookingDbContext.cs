using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class OnlineBookingDbContext : DbContext
    {
        public OnlineBookingDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<TicketInstance> TicketInstances { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
