using System;
using System.Diagnostics;
using DiWalkthrough_007.Class_Hierarchies.Code.DbLayer;

namespace DiWalkthrough_007.Class_Hierarchies.Code.BLLayer
{
    public class UserManager : IDisposable, IUserManager
    {
        private readonly RepositoryBase<User> _userRepository;

        public UserManager(RepositoryBase<User> userRepository)
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
