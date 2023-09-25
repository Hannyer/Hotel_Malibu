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

            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserService, UserService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}