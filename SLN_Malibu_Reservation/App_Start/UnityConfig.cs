using Repository.IRepository;
using Repository.Repository;
using Service.IService;
using Service.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace SLN_Malibu_Reservation
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            //repositorios
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IMenuRepository, MenuRepository>();



            //services
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IMenuService, MenuService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}