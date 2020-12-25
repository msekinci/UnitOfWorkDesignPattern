using UoWApp.BusinessLayer.Interfaces;
using UoWApp.DataAccessLayer.UnitOfWork;
using UoWApp.EntitiesLayer;

namespace UoWApp.BusinessLayer.Concrete
{
    public class AccountManager : GenericManager<Account>, IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
