namespace DomainModels
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public double TotalPrice { get; set; }
        public DateTime DateOfSale { get; set; }

        public ICollection<TicketInstance> TicketInstances { get; set; } // One-to-Many

    }
}
