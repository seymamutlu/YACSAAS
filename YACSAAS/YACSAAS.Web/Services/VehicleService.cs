using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YACSAAS.Infrastructure.UnitOfWork;
using YACSAAS.Repository.Database;
using YACSAAS.Repository.Repositories;
using YACSAAS.Web.Services;

namespace YACSAAS.Service
{
    //Implementation of vehicles service to be accessed 
    //Use this methods in our controllers and add new methods if needed
    public class VehicleService : EntityService<Vehicle>, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleService(IUnitOfWork unitOfWork, IVehicleRepository vehicleRepository)
            : base(unitOfWork, vehicleRepository)
        {
            _unitOfWork = unitOfWork;
            _vehicleRepository = vehicleRepository;
        }

        public Vehicle GetById(int id)
        {
            return _vehicleRepository.GetById(id);
        }
    }
}
