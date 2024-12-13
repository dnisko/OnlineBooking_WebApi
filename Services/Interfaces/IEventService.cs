using DTOs.Event;
using Microsoft.AspNetCore.Mvc;

namespace Services.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventDto>> GetAllEvents();
    }
}
