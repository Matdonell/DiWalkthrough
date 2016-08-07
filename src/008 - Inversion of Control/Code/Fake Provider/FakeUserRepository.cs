using System.Diagnostics;
using DiWalkthrough_008.Inversion_Of_Control.Code.DbLayer;

namespace DiWalkthrough_008.Inversion_Of_Control.Code.Fake_Provider
{
    public class FakeUserRepository : IUserRepository
    {
        public void Add(User user)
        {
            Debugger.Break();
        }

        public User Get(int userId)
        {
            Debugger.Break();
            return null;
        }
    }
}
