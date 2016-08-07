namespace DiWalkthrough_007.Class_Hierarchies.Code.DbLayer
{
    public abstract class RepositoryBase<T>
    {
        public abstract T Get(int id);

        public abstract void Add(T entity);
    }
}
