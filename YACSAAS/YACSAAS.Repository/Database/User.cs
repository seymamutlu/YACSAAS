using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YACSAAS.Repository.Database
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public User(string name, string lastName)
        {
            this.Id = new Guid();
            this.Name = name;
            this.LastName = lastName;
        }
    }
}
