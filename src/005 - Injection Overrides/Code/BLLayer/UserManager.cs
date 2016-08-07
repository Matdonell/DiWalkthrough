using System;
using DiWalkthrough_005.Injection_Overrides.Code.DbLayer;

namespace DiWalkthrough_005.Injection_Overrides.Code.BLLayer
{
    public class UserManager
    {
        public UserManager(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public UserRepository UserRepository { get; }

        public void EnsureUserCreated(int userId, string name)
        {
            try
            {
                UserRepository.Get(userId);
            }
            catch (ArgumentOutOfRangeException)
            {
                UserRepository.Add(new User {UserId = userId, Name = name});
            }
        }
    }
}