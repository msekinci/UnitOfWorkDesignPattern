using UoWApp.BusinessLayer.Interfaces;
using UoWApp.DataAccessLayer.UnitOfWork;

namespace UoWApp.BusinessLayer.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, new()
    {
        private readonly IUnitOfWork _unitOfWork;
        public GenericManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(TEntity entity)
        {
            _unitOfWork.GetRepository<TEntity>().Add(entity);
            _unitOfWork.SaveChanges(); 
        }
    }
}
