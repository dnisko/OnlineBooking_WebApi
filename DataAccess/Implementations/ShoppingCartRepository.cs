using DataAccess.Interfaces;
using DomainModels;
using Microsoft.Extensions.Logging;

namespace DataAccess.Implementations
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(OnlineBookingDbContext context, ILogger<Repository<ShoppingCart>> logger) : base(context, logger)
        {
        }
    }
}
