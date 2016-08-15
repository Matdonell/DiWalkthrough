using System.Diagnostics;
using Autofac;
using DiWalkthrough_006.Injection_Overrides.Code.BLLayer;
using DiWalkthrough_006.Injection_Overrides.Code.DbLayer;

namespace DiWalkthrough_006.Injection_Overrides
{
    class Program
    {
        static void Main()
        {
            IContainer container = GetDiContainer();

            UserManager userManager = container.Resolve<UserManager>();
            UserManager userManager2 = container.Resolve<UserManager>(TypedParameter.From(new UserRepository() { ExtraInfo = "Override!" }));

            string extraInfo = userManager.UserRepository.ExtraInfo;
            string extraInfo2 = userManager2.UserRepository.ExtraInfo;

            Debugger.Break();

            // What to expect: 
            // The extra info on the first userManager will be null
            // The extra info on the second userManager will contain "Override!"
            // As we supplied an existing UserRepository, the container is going to use it.
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



