using System;
using System.Diagnostics;
using DiWalkthrough_009.Unit_Testing.Code.DbLayer;

namespace DiWalkthrough_009.Unit_Testing.Code.BLLayer
{
    public class UserManager : IDisposable, IUserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public void EnsureUserCreated(int userId, string name)
        {
            try
            {
                _userRepository.Get(userId);
            }
            catch (ArgumentOutOfRangeException)
            {
                _userRepository.Add(new User() { UserId = userId, Name = name });
            }
        }

        public void Dispose()
        {
            Debugger.Break();
        }
    }
}
