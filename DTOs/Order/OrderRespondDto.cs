using DTOs.TicketInstance;

namespace DTOs.Order
{
    public class OrderRespondDto
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfSale { get; set; }
        public string UserFullName { get; set; }
        public List<TicketInstanceDto> TicketInstances { get; set; }
    }
}
