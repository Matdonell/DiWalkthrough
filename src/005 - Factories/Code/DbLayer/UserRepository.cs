using System;
using System.Diagnostics;

namespace DiWalkthrough_005.Factories.Code.DbLayer
{
    public class UserRepository
    {
        public string SpecificDependency { get; }

        public UserRepository(string specificDependency)
        {
            SpecificDependency = specificDependency;
        }

        public User Get(int userId)
        {
            Debugger.Break();

            // What to expect: 
            // The SpecificDependency will be filled with a custom value.

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