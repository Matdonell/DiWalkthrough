using System;
using DiWalkthrough_003.DI_Framework.Code.DbLayer;

namespace DiWalkthrough_003.DI_Framework.Code.BLLayer
{
    public class UserManager
    {
        private readonly UserRepository m_userRepository;

        public UserManager(UserRepository userRepository)
        {
            m_userRepository = userRepository;
        }

        public void EnsureUserCreated(int userId, string name)
        {
            try
            {
                m_userRepository.Get(userId);
            }
            catch (ArgumentOutOfRangeException)
            {
                m_userRepository.Add(new User() { UserId = userId, Name = name });
            }
        }
    }
}
