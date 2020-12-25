using UoWApp.DataAccessLayer.Concrete.Context;
using UoWApp.DataAccessLayer.Interfaces;

namespace UoWApp.DataAccessLayer.Concrete.Repositories
{
    public class EFGenericRepository<TEntity> : IGenericDAL<TEntity> where TEntity : class, new()
    {
        private readonly UoWContext _context;
        public EFGenericRepository(UoWContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }
    }
}
