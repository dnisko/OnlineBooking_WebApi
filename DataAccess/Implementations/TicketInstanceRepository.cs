using DataAccess.Interfaces;
using DomainModels;
using Microsoft.Extensions.Logging;

namespace DataAccess.Implementations
{
    public class TicketInstanceRepository : Repository<TicketInstance>, ITicketInstanceRepository
    {
        public TicketInstanceRepository(OnlineBookingDbContext context, ILogger<Repository<TicketInstance>> logger) : base(context, logger)
        {
        }
    }
}
