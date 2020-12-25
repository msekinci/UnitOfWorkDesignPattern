using UoWApp.DataAccessLayer.Concrete.Context;
using UoWApp.DataAccessLayer.Interfaces;
using UoWApp.EntitiesLayer;

namespace UoWApp.DataAccessLayer.Concrete.Repositories
{
    public class EFAccountRepository : EFGenericRepository<Account>, IAccountDAL
    {
        public EFAccountRepository(UoWContext context) : base(context)
        {

        }
    }
}
