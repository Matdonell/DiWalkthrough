using System;
using System.Diagnostics;
using DiWalkthrough_011.Unit_Testing.Code.BLLayer;
using DiWalkthrough_011.Unit_Testing.Code.DbLayer;
using Moq;

namespace DiWalkthrough_011.Unit_Testing
{
    class Program
    {
        static void Main()
        {
            Debugger.Break();

            var userRepository = Mock.Of<IUserRepository>();

            Mock.Get(userRepository)
                .Setup(i => i.Get(It.IsAny<int>()))
                .Throws(new ArgumentOutOfRangeException());

            Mock.Get(userRepository)
                .Setup(i => i.Add(It.IsAny<User>()));

            IUserManager userManager = new UserManager(userRepository);

            userManager.EnsureUserCreated(22, "Some name");

            Debugger.Break();

            // What to expect: 
            // Both mocked calls should have been called. The UserManager didn't use any external dependencies 
            // aside from its DI provided dependencies.

            Mock.Get(userRepository)
                .VerifyAll();
        }
    }
}



