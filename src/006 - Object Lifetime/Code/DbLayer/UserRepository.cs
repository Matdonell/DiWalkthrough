using System;
using System.Diagnostics;

namespace DiWalkthrough_006.Object_Lifetime.Code.DbLayer
{
    public class UserRepository : IDisposable
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

        internal void Add(User user)
        {
            //Add the user right here.
        }

        public void Dispose()
        {
            Debugger.Break();
        }
    }
}