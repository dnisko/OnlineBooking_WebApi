namespace DTOs.Event
{
    public class EventRespondDto
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime DateOfEvent { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string EventType { get; set; }
        public string Venue { get; set; }
    }
}
