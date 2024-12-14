namespace DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<TicketInstance> TicketInstances { get; set; } // One-to-Many

    }
}
