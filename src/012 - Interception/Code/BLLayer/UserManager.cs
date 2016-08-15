using System;
using DiWalkthrough_012.Interception.Code.DbLayer;

namespace DiWalkthrough_012.Interception.Code.BLLayer
{
    public class UserManager
    {
        private readonly IUserRepository m_userRepository;

        public UserManager(IUserRepository userRepository)
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
