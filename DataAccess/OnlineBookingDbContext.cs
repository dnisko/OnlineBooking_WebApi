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

            /*
            builder.Entity<Order>()
                .HasMany(o => o.TicketInstances) // An Order has many TicketInstances
                .WithOne(ti => ti.Order)         // A TicketInstance belongs to one Order
                .HasForeignKey(ti => ti.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete: deleting Order deletes its TicketInstances

            builder.Entity<ShoppingCart>()
                .HasMany(sc => sc.TicketInstances) // A ShoppingCart can hold many TicketInstances
                .WithOne(ti => ti.ShoppingCart)    // A TicketInstance belongs to one ShoppingCart
                .HasForeignKey(ti => ti.ShoppingCartId)
                .OnDelete(DeleteBehavior.Restrict); // Optional: prevent cascading deletes
            */
        }
    }
}
