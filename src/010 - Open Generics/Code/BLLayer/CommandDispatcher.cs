
namespace DiWalkthrough_010.Open_Generics.Code.BLLayer
{
    /// <remarks>
    /// This class is used as a central point for sending commands. 
    /// You could decide to send a specific kind of command through a queue and 
    /// some others in memory for example. You could also decide that at development time
    /// all commands will be dispatched in memory for example.
    /// 
    /// Also, a strongly typed dispatcher is used here to avoid using the 
    /// service locator pattern. If you need to take in commands that you don't 
    /// know the exact type before hand, you might want to use the service locator pattern
    /// (but try to avoid it!)
    /// </remarks>
    public class CommandDispatcher<TCommand>
    {
        private readonly ICommandHandler<TCommand> _commandHandler;

        public CommandDispatcher(ICommandHandler<TCommand> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        public void Dispatch(TCommand command)
        {
            _commandHandler.Execute(command);
        }
    }
}
