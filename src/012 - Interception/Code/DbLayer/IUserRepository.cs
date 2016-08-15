namespace DiWalkthrough_012.Interception.Code.DbLayer
{
    public interface IUserRepository
    {
        User Get(int userId);
        void Add(User user);
    }
}