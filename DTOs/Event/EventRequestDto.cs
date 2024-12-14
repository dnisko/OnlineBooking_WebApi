namespace DTOs.Event
{
    public class EventRequestDto
    {
        public string EventName { get; set; }
        public DateTime DateOfEvent { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string WebPageUrl { get; set; }
        public string VideoUrl { get; set; }
        public int EventTypeId { get; set; }
        public int VenueId { get; set; }
    }
}
