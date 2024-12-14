using DTOs.Event;

namespace Services.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventRequestDto>> GetAllEvents();
    }
}
