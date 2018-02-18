using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YACSAAS.Repository.Database
{
    public class Fleet
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Fleet(string name)
        {
            this.Id = new Guid();
            this.Name = name;
        }
    }
}
