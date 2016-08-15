using System.Diagnostics;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using DiWalkthrough_012.Interception.Code.BLLayer;
using DiWalkthrough_012.Interception.Code.DbLayer;
using DiWalkthrough_012.Interception.Code.Interceptors;

namespace DiWalkthrough_012.Interception
{
    class Program
    {
        static void Main()
        {
            var container = GetDiContainer();

            var userManager = container.Resolve<UserManager>();
            
            userManager.EnsureUserCreated(1, "Foo");

            // What to expect: 
            // Console has the method invocation printed.
            Debugger.Break();
        }

        private static IContainer GetDiContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<TraceInterceptor>();

            containerBuilder.RegisterType<UserManager>();
            containerBuilder.RegisterType<UserRepository>()
                .As<IUserRepository>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TraceInterceptor));



            return containerBuilder.Build();
        }
    }
}



