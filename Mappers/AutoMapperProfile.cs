using AutoMapper;
using DomainModels;
using DTOs.Event;

namespace Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Event, EventDto>().ReverseMap();
        }
    }
}
