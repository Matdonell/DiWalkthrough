using System;
using System.Diagnostics;
using DiWalkthrough_006.Object_Lifetime.Code.DbLayer;

namespace DiWalkthrough_006.Object_Lifetime.Code.BLLayer
{
    public class UserManager : IDisposable
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

        public void Dispose()
        {
            Debugger.Break();
        }
    }
}
