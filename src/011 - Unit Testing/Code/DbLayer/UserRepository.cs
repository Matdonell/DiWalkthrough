using System;

namespace DiWalkthrough_011.Unit_Testing.Code.DbLayer
{
    public class UserRepository : IUserRepository
    {
        public User Get(int userId)
        {
            if (userId == 1)
            {
                return new User()
                {UserId = 1, Name = "Foo"};
            }

            if (userId == 2)
            {
                return new User()
                {UserId = 2, Name = "Bar"};
            }

            throw new ArgumentOutOfRangeException($"User {userId} not found.");
        }

        public void Add(User user)
        {
            //Add the user right here.
        }
    }
}