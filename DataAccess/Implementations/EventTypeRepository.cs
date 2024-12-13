using DataAccess.Interfaces;
using DomainModels;
using Microsoft.Extensions.Logging;

namespace DataAccess.Implementations
{
    public class EventTypeRepository : Repository<EventType>, IEventTypeRepository
    {
        public EventTypeRepository(OnlineBookingDbContext context, ILogger<Repository<EventType>> logger) : base(context, logger)
        {
        }
    }
}
