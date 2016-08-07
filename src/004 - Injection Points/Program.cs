using System.Diagnostics;
using Autofac;
using DiWalkthrough_004.Injection_Points.Code.BLLayer;
using DiWalkthrough_004.Injection_Points.Code.DbLayer;

namespace DiWalkthrough_004.Injection_Points
{
    class Program
    {
        static void Main()
        {
            IContainer container = GetDiContainer();

            UserManager userManager = container.Resolve<UserManager>();

            Debugger.Break();

            // What to expect: 
            // This is going to work because the container built the user manager and its dependencies.

            userManager.EnsureUserCreated(1, "Foo");
        }

        private static IContainer GetDiContainer()
        {
            Debugger.Break();

            // What's happening here: 
            // We are registering the available classes into the container so we can later resolve them.

            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<UserManager>()
                            // By calling the PropertiesAutowired method, the container gets told to resolve dependencies for all the properties.
                            .PropertiesAutowired();
            containerBuilder.RegisterType<UserRepository>();

            return containerBuilder.Build();
        }
    }
}



