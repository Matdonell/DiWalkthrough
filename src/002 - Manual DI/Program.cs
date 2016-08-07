using System.Diagnostics;
using DiWalkthrough_002.Manual_DI.Code.BLLayer;
using DiWalkthrough_002.Manual_DI.Code.DbLayer;

namespace DiWalkthrough_002.Manual_DI
{
    class Program
    {
        static void Main()
        {
            UserRepository userRepository = new UserRepository();
            UserManager userManager = new UserManager(userRepository);

            Debugger.Break();

            // What to expect: 
            // This is going to work because we provided a user repository to the user manager.

            userManager.EnsureUserCreated(1, "Foo");
        }
    }
}



