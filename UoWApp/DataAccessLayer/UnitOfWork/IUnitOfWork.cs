using UoWApp.DataAccessLayer.Interfaces;

namespace UoWApp.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IAccountDAL AccountDAL { get; set; }
        void SaveChanges();
        IGenericDAL<TEntity> GetRepository<TEntity>() where TEntity : class, new();
    }
}
