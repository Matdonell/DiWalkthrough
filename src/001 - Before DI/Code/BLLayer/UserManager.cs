using System;
using DiWalkthrough_001.Before_DI.Code.DbLayer;

namespace DiWalkthrough_001.Before_DI.Code.BLLayer
{
    public class UserManager
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public void EnsureUserCreated(int userId, string name)
        {
            try
            {
                _userRepository.Get(userId);
            }
            catch (ArgumentOutOfRangeException)
            {
                _userRepository.Add(new User {UserId = userId, Name = name});
            }
        }
    }
}