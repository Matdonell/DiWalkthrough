using System;
using DiWalkthrough_004.Injection_Points.Code.DbLayer;

namespace DiWalkthrough_004.Injection_Points.Code.BLLayer
{
    public class UserManager
    {
        public UserRepository UserRepository { get; set; }

        public void EnsureUserCreated(int userId, string name)
        {
            try
            {
                UserRepository.Get(userId);
            }
            catch (ArgumentOutOfRangeException)
            {
                UserRepository.Add(new User() { UserId = userId, Name = name });
            }
        }
    }
}
