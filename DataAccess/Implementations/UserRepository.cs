using DataAccess.Interfaces;
using DomainModels;
using Microsoft.Extensions.Logging;

namespace DataAccess.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(OnlineBookingDbContext context, ILogger<Repository<User>> logger) : base(context, logger)
        {
        }
    }
}
