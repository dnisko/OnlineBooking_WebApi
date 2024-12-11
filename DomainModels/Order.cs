namespace DomainModels
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int TicketInstanceId { get; set; }
        public TicketInstance TicketInstance { get; set; }
        
        public DateTime DateOfSale { get; set; }
    }
}
