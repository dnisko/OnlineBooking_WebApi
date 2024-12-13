using AutoMapper;
using DataAccess.Interfaces;
using DTOs.Event;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Services.Implementations
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EventDto>> GetAllEvents()
        {
            var allEvents = await _eventRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EventDto>>(allEvents);
        }
    }
}
