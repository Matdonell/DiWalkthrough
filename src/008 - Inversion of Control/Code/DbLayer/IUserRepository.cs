namespace DiWalkthrough_008.Inversion_Of_Control.Code.DbLayer
{
    public interface IUserRepository
    {
        void Add(User user);
        User Get(int userId);
    }
}