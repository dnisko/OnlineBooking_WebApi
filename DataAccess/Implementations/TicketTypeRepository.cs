using DataAccess.Interfaces;
using DomainModels;
using Microsoft.Extensions.Logging;

namespace DataAccess.Implementations
{
    public class TicketTypeRepository : Repository<TicketType>, ITicketTypeRepository
    {
        public TicketTypeRepository(OnlineBookingDbContext context, ILogger<Repository<TicketType>> logger) : base(context, logger)
        {
        }
    }
}
