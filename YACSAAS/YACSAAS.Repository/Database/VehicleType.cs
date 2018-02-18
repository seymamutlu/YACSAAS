using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YACSAAS.Repository.Database
{
    public class VehicleType
    {
        public int Id { get; internal set; }
        public string Name { get; private set; }

        public VehicleType(string name)
        {
            this.Name = name;
        }
    }
}