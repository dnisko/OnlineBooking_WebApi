namespace DomainModels
{
    public class TicketType : BaseEntity
    {
        public string Zone { get; set; }
        public decimal Price { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
