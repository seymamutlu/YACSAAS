using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YACSAAS.Infrastructure.Domain;

namespace YACSAAS.Repository.Database
{
    public class Vehicle : Entity<int>, IEnumerable
    {
        private IEnumerable _enumerableImplementation;

        public int Id { get; internal set; }
        public int ManufacturerId { get; set; }
        public int VehicleTypeId { get; set; }
        public string LicensePlate { get; set; }


        public IEnumerator GetEnumerator()
        {
            return _enumerableImplementation.GetEnumerator();
        }
    }
}
