using System.Data.Entity;
using Autofac;
using YACSAAS.Infrastructure.UnitOfWork;
using YACSAAS.Repository.Database;
using YACSAAS.Repository.Repositories;

namespace YACSAAS.Web.Module
{
    //Autofac registiration for entity framework module
    public class EfModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterType(typeof(YACSAASDbContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
        }
    }
}