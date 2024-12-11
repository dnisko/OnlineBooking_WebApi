namespace DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int TicketInstanceId { get; set; }
        public TicketInstance TicketInstance { get; set; }
    }
}
