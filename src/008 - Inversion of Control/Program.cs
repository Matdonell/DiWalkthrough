using System.Diagnostics;
using Autofac;
using DiWalkthrough_008.Inversion_Of_Control.Code.BLLayer;
using DiWalkthrough_008.Inversion_Of_Control.Code.DbLayer;
using DiWalkthrough_008.Inversion_Of_Control.Code.Fake_Provider;

namespace DiWalkthrough_008.Inversion_Of_Control
{
    class Program
    {
        static void Main()
        {
            IContainer container = GetDiContainer();

            IUserManager userManager = container.Resolve<IUserManager>();

            Debugger.Break();

            // What to expect: 
            // The resolved UserRepository will the be the expected UserRepository, but a FakeRepository.
            // The UserManager doesn't care about the actual implementation of its dependencies.

            userManager.EnsureUserCreated(1, "Foo");
        }

        private static IContainer GetDiContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<UserManager>()
                            .As<IUserManager>();
            containerBuilder.RegisterType<FakeUserRepository>()
                            .As<IUserRepository>();

            return containerBuilder.Build();
        }
    }
}



