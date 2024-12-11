using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class OnlineBookingDbContext : DbContext
    {
        DbSet<Event> Events { get; set; }
        DbSet<EventType> EventTypes { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<ShoppingCart> ShoppingCarts { get; set; }
        DbSet<TicketInstance> TicketInstances { get; set; }
        DbSet<TicketType> TicketTypes { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
