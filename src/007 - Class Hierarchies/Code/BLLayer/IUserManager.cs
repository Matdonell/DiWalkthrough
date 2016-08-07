namespace DiWalkthrough_007.Class_Hierarchies.Code.BLLayer
{
    public interface IUserManager
    {
        void Dispose();
        void EnsureUserCreated(int userId, string name);
    }
}