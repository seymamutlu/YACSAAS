using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YACSAAS.Domain.ValueObjects;
using YACSAAS.Infrastructure.Domain;

namespace YACSAAS.Domain.Vehicle
{
    public class Vehicle : EntityBase<int>, IAggregateRoot
    {
        public string Model { get; set; }
        public VehicleType VehicleType { get; set; }
        public Manufacturer Manufacturer { get; set; }

        protected override void Validate()
        {
            if (string.IsNullOrEmpty(Model))
            {
                AddBrokenRule(VehicleBusinessRule.VehicleModelRequired);
            }
        }
    }
}
