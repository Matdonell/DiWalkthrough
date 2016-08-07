namespace DiWalkthrough_008.Inversion_Of_Control.Code.BLLayer
{
    public interface IUserManager
    {
        void Dispose();
        void EnsureUserCreated(int userId, string name);
    }
}