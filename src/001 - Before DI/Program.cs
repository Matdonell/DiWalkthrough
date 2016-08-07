using System.Diagnostics;
using DiWalkthrough_001.Before_DI.Code.BLLayer;

namespace DiWalkthrough_001.Before_DI
{
    internal class Program
    {
        private static void Main()
        {
            var userManager = new UserManager();

            Debugger.Break();

            // What to expect: 
            // This is going to work because the UserManager initilises its own user repository.

            userManager.EnsureUserCreated(1, "Foo");
        }
    }
}