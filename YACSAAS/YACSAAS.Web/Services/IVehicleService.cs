using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YACSAAS.Repository.Database;

namespace YACSAAS.Web.Services
{
    public interface IVehicleService : IEntityService<Vehicle>
    {
        Vehicle GetById(int id);
    }
}