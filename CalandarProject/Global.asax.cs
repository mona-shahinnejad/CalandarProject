using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CalandarProject.IOC;
using Services.IService;

namespace CalandarProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoFacContainer.ConfigureContainer();

            var SeedDataService = DependencyResolver.Current.GetService<ISeedDataService>();
            SeedDataService.SeedData();
        }
    }
}
