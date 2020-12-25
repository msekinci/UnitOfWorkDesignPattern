using Microsoft.Extensions.DependencyInjection;
using System;
using UoWApp.BusinessLayer.Concrete;
using UoWApp.BusinessLayer.Interfaces;
using UoWApp.DataAccessLayer.Concrete.Context;
using UoWApp.DataAccessLayer.Concrete.Repositories;
using UoWApp.DataAccessLayer.Interfaces;
using UoWApp.DataAccessLayer.UnitOfWork;
using UoWApp.EntitiesLayer;

namespace UoWApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new ServiceCollection().AddDbContext<UoWContext>()
            .AddScoped(typeof(IGenericService<>), typeof(GenericManager<>))
            .AddScoped(typeof(IGenericDAL<>), typeof(EFGenericRepository<>))
            .AddScoped<IAccountService, AccountManager>()
            .AddScoped<IUnitOfWork, UnitOfWork>()
            .BuildServiceProvider();

            var accountService = provider.GetService<IAccountService>();
            accountService.Add(new Account
            {
                CustomerName = "Selin",
                Total = 1500
            });
            Console.WriteLine("Task successful");
        }
    }
}
