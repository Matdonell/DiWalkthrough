namespace DiWalkthrough_010.Open_Generics.Code.BLLayer.Commands
{
    public class CreateUserCommand
    {
        public string Name { get; }
        public int UserId { get; }

        public CreateUserCommand(int userId, string name)
        {
            UserId = userId;
            Name = name;
        }
    }
}