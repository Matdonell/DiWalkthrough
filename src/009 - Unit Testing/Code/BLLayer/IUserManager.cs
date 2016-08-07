namespace DiWalkthrough_009.Unit_Testing.Code.BLLayer
{
    public interface IUserManager
    {
        void Dispose();
        void EnsureUserCreated(int userId, string name);
    }
}