namespace DTOs.Order
{
    public class OrderRequestDto
    {
        public int UserId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfSale { get; set; }

        public List<int> TicketInstanceIds { get; set; } // Multiple tickets in one order
    }
}
