using System;

namespace DiWalkthrough_007.Class_Hierarchies.Code.DbLayer
{
    public class UserRepository : RepositoryBase<User>
    {
        public override User Get(int userId)
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

        public override void Add(User user)
        {
            //Add the user right here.
        }
    }
}