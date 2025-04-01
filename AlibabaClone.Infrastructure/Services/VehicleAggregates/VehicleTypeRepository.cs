using AlibabaClone.Domain.Aggregates.VehicleAggregates;
using AlibabaClone.Domain.Framework.Interfaces.Repositories.VehicleRepositories;
using AlibabaClone.Infrastructure.Framework.Base;

namespace AlibabaClone.Infrastructure.Services.VehicleAggregates
{
    public class VehicleTypeRepository : Repository<ApplicationDBContext, VehicleType, int>, IVehicleTypeRepository
    {
        public VehicleTypeRepository (ApplicationDBContext dbContext) : base (dbContext)
        {

        }
    }
}