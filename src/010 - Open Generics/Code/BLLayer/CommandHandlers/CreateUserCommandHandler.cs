using DiWalkthrough_010.Open_Generics.Code.BLLayer.Commands;
using DiWalkthrough_010.Open_Generics.Code.DbLayer;

namespace DiWalkthrough_010.Open_Generics.Code.BLLayer.CommandHandlers
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository m_userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            m_userRepository = userRepository;
        }

        public void Execute(CreateUserCommand command)
        {
            m_userRepository.Add(new User() { UserId = command.UserId, Name = command.Name });
        }
    }
}
