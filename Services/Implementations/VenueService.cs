using AutoMapper;
using DataAccess.Interfaces;
using Services.Interfaces;

namespace Services.Implementations
{
    public class VenueService : IVenueService
    {
        private readonly IVenueRepository _repository;
        private readonly IMapper _mapper;

        public VenueService(IVenueRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
