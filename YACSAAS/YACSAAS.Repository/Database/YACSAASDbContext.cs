using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace YACSAAS.Repository.Database
{
    //The definition of db context for our project
    public class YACSAASDbContext : DbContext
    {
        public YACSAASDbContext() : base("name=YACSAASDbContext")
        {
        }

        //Add the following models to the db context to create tables using entity framework code first
        public DbSet<User> Users { get; set; }

        public DbSet<Fleet> Bouquets { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //We can add other constraints to the tables in the database
        }
    }

}