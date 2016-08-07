namespace DiWalkthrough_010.Open_Generics.Code.DbLayer
{
    public interface IUserRepository
    {
        void Add(User user);
        User Get(int userId);
    }
}