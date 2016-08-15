using Autofac;
using DiWalkthrough_005.Factories.Code.BLLayer;
using DiWalkthrough_005.Factories.Code.DbLayer;

namespace DiWalkthrough_005.Factories
{
    internal class Program
    {
        private static void Main()
        {
            var container = GetDiContainer();

            var userManager = container.Resolve<UserManager>();
            
            userManager.EnsureUserCreated(1, "Foo");
        }

        private static IContainer GetDiContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<UserManager>();
            containerBuilder.RegisterType<UserRepository>();

            return containerBuilder.Build();
        }
    }
}