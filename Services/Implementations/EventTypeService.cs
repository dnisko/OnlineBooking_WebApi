using AutoMapper;
using DataAccess.Interfaces;
using Services.Interfaces;

namespace Services.Implementations
{
    public class EventTypeService : IEventTypeService
    {
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly IMapper _mapper;

        public EventTypeService(IEventTypeRepository eventTypeRepository, IMapper mapper)
        {
            _eventTypeRepository = eventTypeRepository;
            _mapper = mapper;
        }


    }
}
