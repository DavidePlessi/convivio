using Microsoft.EntityFrameworkCore;

namespace Convivio.API.Services
{
    public abstract class BaseService<TDbContext>
        where TDbContext : DbContext
    {
        protected TDbContext DbContext { get; }

        protected BaseService(TDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}