using KMISMRepository;
using KMISMService;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace KMISMWebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<StudentRepository, StudentRepository>();
            container.RegisterType<LoginUserRepository, LoginUserRepository>();
            container.RegisterType<SubjectRepository, SubjectRepository>();
            container.RegisterType<StudentService, StudentService>();
            container.RegisterType<LoginUserService, LoginUserService>();
            container.RegisterType<SubjectService, SubjectService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}