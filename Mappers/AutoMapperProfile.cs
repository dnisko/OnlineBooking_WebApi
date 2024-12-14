using AutoMapper;
using DomainModels;
using DTOs.Event;
using DTOs.EventType;
using DTOs.Order;
using DTOs.ShoppingCart;
using DTOs.TicketInstance;
using DTOs.TicketType;
using DTOs.User;
using DTOs.Venue;

namespace Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Event
            CreateMap<Event, EventRequestDto>();
            CreateMap<Event, EventRespondDto>()
                .ForMember(dest => dest.EventType, opt => opt.MapFrom(src => src.EventType.Description))
                .ForMember(dest => dest.Venue, opt => opt.MapFrom(src => src.Venue.VenueName));

            // EventType
            CreateMap<EventType, EventTypeDto>();

            // Order
            CreateMap<Order, OrderRequestDto>()
                .ForMember(dest => 
                    dest.TicketInstanceIds, opt => 
                    opt.MapFrom(src => src.TicketInstances.Select(ti => ti.Id).ToList()))
                .ReverseMap();

            // ShoppingCart
            CreateMap<ShoppingCart, ShoppingCartRequestDto>()
                .ForMember(dest => 
                    dest.TicketInstanceIds, opt => 
                    opt.MapFrom(src => src.TicketInstances.Select(ti => ti.Id).ToList()))
                .ReverseMap();
            CreateMap<ShoppingCart, ShoppingCartRespondDto>()
                .ForMember(dest => 
                    dest.UserName, opt => 
                    opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName)) // Assuming you concatenate first and last name
                .ReverseMap();

            // TicketInstance
            CreateMap<TicketInstance, TicketInstanceDto>();

            // TicketType
            CreateMap<TicketType, TicketTypeDto>()
                .ForMember(dest => 
                    dest.EventName, opt => 
                    opt.MapFrom(src => src.Event.EventName))
                .ReverseMap();

            // User
            CreateMap<User, UserRequestDto>().ReverseMap(); // ReverseMap needed for Create/Update
            CreateMap<User, UserRespondDto>().ReverseMap();
                //.ForMember(dest => dest.Password, opt => opt.Ignore());

            // Venue
            CreateMap<Venue, VenueRequestDto>();
            CreateMap<Venue, VenueRespondDto>();
            /*
            //Event
            CreateMap<Event, EventRequestDto>().ReverseMap();
            CreateMap<Event, EventRespondDto>().ReverseMap();

            //EventType
            CreateMap<EventType, EventTypeDto>().ReverseMap();

            //Order
            CreateMap<Order, OrderRequestDto>().ReverseMap();
            CreateMap<Order, OrderRespondDto>().ReverseMap();

            //ShoppingCart
            CreateMap<ShoppingCart, ShoppingCartRequestDto>().ReverseMap();
            CreateMap<ShoppingCart, ShoppingCartRespondDto>().ReverseMap();

            //TicketInstance
            CreateMap<TicketInstance, TicketInstanceDto>().ReverseMap();

            //TicketType
            CreateMap<TicketType, TicketTypeDto>().ReverseMap();

            //User
            CreateMap<User, UserRequestDto>().ReverseMap();
            CreateMap<User, UserRespondDto>().ReverseMap();

            //Venue
            CreateMap<Venue, VenueRequestDto>().ReverseMap();
            CreateMap<Venue, VenueRespondDto>().ReverseMap();
            */
        }
    }
}
