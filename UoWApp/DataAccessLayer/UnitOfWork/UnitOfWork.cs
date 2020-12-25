using UoWApp.DataAccessLayer.Concrete.Context;
using UoWApp.DataAccessLayer.Concrete.Repositories;
using UoWApp.DataAccessLayer.Interfaces;

namespace UoWApp.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAccountDAL AccountDAL { get; set; }
        private readonly UoWContext _context;

        public UnitOfWork(UoWContext context)
        {
            _context = context;
            AccountDAL = new EFAccountRepository(_context);
        }

        public IGenericDAL<TEntity> GetRepository<TEntity>() where TEntity:class, new()
        {
            return new EFGenericRepository<TEntity>(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
