using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YACSAAS.Repository.Database
{
    public class Manufacturer
    {
        public int Id { get; internal set; }
        public string Name { get; private set; }

        public Manufacturer(string name)
        {
            this.Name = name;
        }
    }
}
