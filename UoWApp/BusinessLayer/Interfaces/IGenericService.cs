namespace UoWApp.BusinessLayer.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, new()
    {
        void Add(TEntity entity);
    }
}
