using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YACSAAS.Infrastructure.Domain;

namespace YACSAAS.Domain.ValueObjects
{
    public abstract class Manufacturer : ValueObjectBase
    {
        public abstract string Id { get; }
        public abstract string Name { get; }

        protected override void Validate()
        {
            if (string.IsNullOrEmpty(Id)) AddBrokenRule(ValueObjectBusinessRule.ManufacturerIdRequired);
            if (string.IsNullOrEmpty(Name)) AddBrokenRule(ValueObjectBusinessRule.ManufacturerNameRequired);
        }
    }
}
