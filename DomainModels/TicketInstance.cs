namespace DomainModels
{
    public class TicketInstance : BaseEntity
    {
        public string Barcode { get; set; }
        public string? Row { get; set; }
        public string? SeatNumber { get; set; }

        public int TicketTypeId { get; set; }
        public TicketType TicketType { get; set; }

        public int IsReserved { get; set; } = 0;
    }
}
