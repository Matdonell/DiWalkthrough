using System.Diagnostics;
using Autofac;
using DiWalkthrough_003.DI_Framework.Code.BLLayer;
using DiWalkthrough_003.DI_Framework.Code.DbLayer;

namespace DiWalkthrough_003.DI_Framework
{
    internal class Program
    {
        private static void Main()
        {
            var container = GetDiContainer();

            var userManager = container.Resolve<UserManager>();

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

            containerBuilder.RegisterType<UserManager>();
            containerBuilder.RegisterType<UserRepository>();

            return containerBuilder.Build();
        }
    }
}