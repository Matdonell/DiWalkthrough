using System.Diagnostics;
using Autofac;
using DiWalkthrough_007.Class_Hierarchies.Code.BLLayer;
using DiWalkthrough_007.Class_Hierarchies.Code.DbLayer;

namespace DiWalkthrough_007.Class_Hierarchies
{
    class Program
    {
        static void Main()
        {
            IContainer container = GetDiContainer();

            IUserManager userManager = container.Resolve<IUserManager>();

            Debugger.Break();

            // What to expect: 
            // A required dependency can be resolved as a child class or interface implementor.

            userManager.EnsureUserCreated(1, "Foo");
        }

        private static IContainer GetDiContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<UserManager>()
                            .As<IUserManager>();
            containerBuilder.RegisterType<UserRepository>()
                            .As<RepositoryBase<User>>();

            return containerBuilder.Build();
        }
    }
}



