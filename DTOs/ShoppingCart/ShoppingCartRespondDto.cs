using DTOs.TicketInstance;

namespace DTOs.ShoppingCart
{
    public class ShoppingCartRespondDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<TicketInstanceDto> TicketInstances { get; set; }
    }
}
