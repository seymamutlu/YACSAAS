using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YACSAAS.Repository.Database;

namespace YACSAAS.Repository.Repositories
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(DbContext context)
            : base(context)
        {
        }

        public override IEnumerable<Vehicle> GetAll()
        {
            return _entities.Set<Vehicle>().ToList();
        }

        public Vehicle GetById(int id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }
    }

    public interface IVehicleRepository : IGenericRepository<Vehicle>
    {
        Vehicle GetById(int id);
    }
}
