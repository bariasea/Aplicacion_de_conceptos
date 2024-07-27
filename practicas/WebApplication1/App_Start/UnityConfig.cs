using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using WebApplication1.Models;
using WebApplication1.Repository;
using WebApplication1.Services;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<INotaRepository, NotaRepository>();
            container.RegisterType<DbModels, DbModels>();
            container.RegisterType<INotaService, NotaService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}