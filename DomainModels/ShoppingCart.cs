namespace DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public int UserId { get; set; }
        public int TicketInstanceId { get; set; }
    }
}
