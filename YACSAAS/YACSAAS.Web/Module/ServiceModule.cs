using System.Reflection;
using Autofac;

namespace YACSAAS.Web.Module
{
    //Autofac registiration for service module
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterAssemblyTypes(Assembly.Load("YACSAAS.Service"))
            //    .Where(t => t.Name.EndsWith("Service"))
            //    .AsImplementedInterfaces()
            //    .InstancePerLifetimeScope();
        }
    }
}