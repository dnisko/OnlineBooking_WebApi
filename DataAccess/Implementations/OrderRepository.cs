using DataAccess.Interfaces;
using DomainModels;
using Microsoft.Extensions.Logging;

namespace DataAccess.Implementations
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(OnlineBookingDbContext context, ILogger<Repository<Order>> logger) : base(context, logger)
        {
        }
    }
}
