using System.Diagnostics;
using Autofac;
using DiWalkthrough_009.Object_Lifetime.Code.BLLayer;
using DiWalkthrough_009.Object_Lifetime.Code.DbLayer;

namespace DiWalkthrough_009.Object_Lifetime
{
    class Program
    {
        private static readonly object s_instance = new object();

        static void Main()
        {
            IContainer container = GetDiContainer();

            object instance;

            using (var lifetimeScope = container.BeginLifetimeScope())
            {
                UserManager userManager = lifetimeScope.Resolve<UserManager>();

                userManager.EnsureUserCreated(1, "Foo");

                instance = lifetimeScope.Resolve<object>();
            }

            bool referenceEquals = object.ReferenceEquals(container.Resolve<object>(), instance);
            Debugger.Break();

            // What to expect: 
            // The reference should be the same since we resolved a dependency that is registered as an instance.
        }

        private static IContainer GetDiContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<UserManager>();
            containerBuilder.RegisterType<UserRepository>();

            //We can register specific instances!
            containerBuilder.RegisterInstance(s_instance);

            return containerBuilder.Build();
        }
    }
}



