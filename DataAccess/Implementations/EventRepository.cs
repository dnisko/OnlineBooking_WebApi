using DataAccess.Interfaces;
using DomainModels;
using Microsoft.Extensions.Logging;

namespace DataAccess.Implementations
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(OnlineBookingDbContext context, ILogger<Repository<Event>> logger) : base(context, logger)
        {
        }
    }
}
