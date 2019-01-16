using Autofac;
using Autofac.Integration.Mvc;
using Services.IOC;
using System.Web.Mvc;
using CalandarProject.Controllers;
using System.Reflection;

namespace CalandarProject.IOC
{
    public class AutoFacContainer
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new ServicesContainer());
            builder.RegisterModule(new ServicesAutoMapperInstaller());
            builder.RegisterModule(new AutoMapperInstaller());

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); //Set the MVC DependencyResolver
        }
    }
}