using AutoMapper;
using DataAccess.Interfaces;
using Services.Interfaces;

namespace Services.Implementations
{
    public class TicketInstanceService : ITicketInstanceService
    {
        private readonly ITicketInstanceRepository _ticketInstanceRepository;
        private readonly IMapper _mapper;

        public TicketInstanceService(ITicketInstanceRepository ticketInstanceRepository, IMapper mapper)
        {
            _ticketInstanceRepository = ticketInstanceRepository;
            _mapper = mapper;
        }
    }
}
