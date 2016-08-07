using System.Diagnostics;
using Autofac;
using DiWalkthrough_010.Open_Generics.Code.BLLayer;
using DiWalkthrough_010.Open_Generics.Code.BLLayer.CommandHandlers;
using DiWalkthrough_010.Open_Generics.Code.BLLayer.Commands;
using DiWalkthrough_010.Open_Generics.Code.DbLayer;

namespace DiWalkthrough_010.Open_Generics
{
    class Program
    {
        static void Main()
        {
            IContainer container = GetDiContainer();

            CommandDispatcher<CreateUserCommand> commandDispatcher = container.Resolve<CommandDispatcher<CreateUserCommand>>();

            Debugger.Break();

            // What to expect: 
            // We were able to resolve a generic type that was not specificaly registered into the container.

            commandDispatcher.Dispatch(new CreateUserCommand(1, "Some Name"));
        }

        private static IContainer GetDiContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterGeneric(typeof(CommandDispatcher<>));

            containerBuilder.RegisterType<CreateUserCommandHandler>()
                            .As<ICommandHandler<CreateUserCommand>>();

            containerBuilder.RegisterType<UserRepository>()
                            .As<IUserRepository>();

            return containerBuilder.Build();
        }
    }
}



