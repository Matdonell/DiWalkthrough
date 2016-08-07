using System;
using System.Diagnostics;
using DiWalkthrough_008.Inversion_Of_Control.Code.DbLayer;

namespace DiWalkthrough_008.Inversion_Of_Control.Code.BLLayer
{
    public class UserManager : IDisposable, IUserManager
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

        public void Dispose()
        {
            Debugger.Break();
        }
    }
}
