using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YACSAAS.Infrastructure.Domain;

namespace YACSAAS.Domain.ValueObjects
{
    public static class ValueObjectBusinessRule
    {
        public static readonly BusinessRule ManufacturerNameRequired = new BusinessRule("Manufacturer must have a name");
        public static readonly BusinessRule ManufacturerIdRequired = new BusinessRule("Manufacturer must have an id");
        public static readonly BusinessRule VehicleTypeIdRequired = new BusinessRule("VehicleType must have a name");
        public static readonly BusinessRule VehicleTypeNameRequired = new BusinessRule("VehicleType must have an id");



    }
}
