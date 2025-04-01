using AlibabaClone.Domain.Aggregates.AccountAggregates;
using AlibabaClone.Domain.Framework.Interfaces.Repositories.AccountRepositories;
using AlibabaClone.Infrastructure.Framework.Base;

namespace AlibabaClone.Infrastructure.Services.AccountAggregates
{
    public class RoleRepository : Repository<ApplicationDBContext, Role, short>, IRoleRepository
    {
        public RoleRepository (ApplicationDBContext dbContext) : base (dbContext)
        {

        }
    }
}