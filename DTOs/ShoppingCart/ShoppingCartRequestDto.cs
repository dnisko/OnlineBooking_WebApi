namespace DTOs.ShoppingCart
{
    public class ShoppingCartRequestDto
    {
        public int UserId { get; set; }

        public List<int> TicketInstanceIds { get; set; }
    }
}
