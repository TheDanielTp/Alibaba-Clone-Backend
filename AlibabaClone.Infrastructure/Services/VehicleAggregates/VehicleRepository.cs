using AlibabaClone.Domain.Aggregates.VehicleAggregates;
using AlibabaClone.Domain.Framework.Interfaces.Repositories.VehicleRepositories;
using AlibabaClone.Infrastructure.Framework.Base;

namespace AlibabaClone.Infrastructure.Services.VehicleAggregates
{
    public class VehicleRepository : Repository<ApplicationDBContext, Vehicle, int>, IVehicleRepository
    {
        public VehicleRepository (ApplicationDBContext dbContext) : base (dbContext)
        {

        }
    }
}