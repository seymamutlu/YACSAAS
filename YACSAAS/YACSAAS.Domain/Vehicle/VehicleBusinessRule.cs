using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YACSAAS.Infrastructure.Domain;

namespace YACSAAS.Domain.Vehicle
{
    public static class VehicleBusinessRule
    {
        public static readonly BusinessRule VehicleModelRequired = new BusinessRule("A vehicle must have a model.");
        public static readonly BusinessRule VehicleTypeRequired = new BusinessRule("Vehicle must have a vehicle type");
        public static readonly BusinessRule ManufacturerRequired = new BusinessRule("Vehicle must have a manufacturer");
    }
}
