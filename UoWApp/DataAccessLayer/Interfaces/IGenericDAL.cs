namespace UoWApp.DataAccessLayer.Interfaces
{
    public interface IGenericDAL<TEntity> where TEntity:class, new()
    {
        void Add(TEntity entity);
    }
}
