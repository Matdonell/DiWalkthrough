using System;
using DiWalkthrough_005.Factories.Code.DbLayer;

namespace DiWalkthrough_005.Factories.Code.BLLayer
{
    public class UserManager
    {
        private readonly Func<string, UserRepository> _userRepositoryFactory;

        public UserManager(Func<string, UserRepository> userRepositoryFactory)
        {
            _userRepositoryFactory = userRepositoryFactory;
        }

        public void EnsureUserCreated(int userId, string name)
        {
            try
            {
                _userRepositoryFactory("Get!").Get(userId);
            }
            catch (ArgumentOutOfRangeException)
            {
                _userRepositoryFactory("Didn't exist :(").Add(new User() { UserId = userId, Name = name });
            }
        }
    }
}
