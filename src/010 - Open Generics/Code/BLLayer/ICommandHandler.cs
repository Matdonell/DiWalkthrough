namespace DiWalkthrough_010.Open_Generics.Code.BLLayer
{
    public interface ICommandHandler<TCommand>
    {
        void Execute(TCommand command);
    }
}