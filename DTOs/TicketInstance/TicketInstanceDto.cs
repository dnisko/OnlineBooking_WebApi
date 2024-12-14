namespace DTOs.TicketInstance
{
    public class TicketInstanceDto
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string? Row { get; set; }
        public string? SeatNumber { get; set; }
        public bool IsReserved { get; set; }
    }
}
