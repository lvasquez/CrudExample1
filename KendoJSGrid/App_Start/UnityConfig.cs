using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using KendoJSGrid.Services;

namespace KendoJSGrid
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICatalogService, CatalogServices>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}