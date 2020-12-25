using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UoWApp.EntitiesLayer;

namespace UoWApp.DataAccessLayer.Concrete.Context
{
    public class UoWContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Serkan-Ekinci;Database=UoW; Trusted_Connection=True;");
        }
        public DbSet<Account> Accounts { get; set; }
    }
}
