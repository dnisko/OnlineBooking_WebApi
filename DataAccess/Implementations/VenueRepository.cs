using DataAccess.Interfaces;
using DomainModels;
using Microsoft.Extensions.Logging;

namespace DataAccess.Implementations
{
    public class VenueRepository : Repository<Venue>, IVenueRepository
    {
        public VenueRepository(OnlineBookingDbContext context, ILogger<Repository<Venue>> logger) : base(context, logger)
        {
        }
    }
}
