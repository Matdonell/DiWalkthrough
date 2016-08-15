namespace DiWalkthrough_011.Unit_Testing.Code.DbLayer
{
    public interface IUserRepository
    {
        void Add(User user);
        User Get(int userId);
    }
}