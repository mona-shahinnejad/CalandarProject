using Autofac;
using Domain;

namespace Services.IOC
{
    public class ServicesContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CalendarDatabaseContext>().InstancePerRequest();
            builder.RegisterAssemblyTypes(ThisAssembly)
                    .Where(c => c.Name.EndsWith("Service"))
                    .AsImplementedInterfaces();
        }
    }
}
