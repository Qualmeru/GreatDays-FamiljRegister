using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Register_Data
{
    public class MainDB : DbContext
    {
        public MainDB() : base("FamiljRegister")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MainDB, Migrations.Configuration>());
          
            Database.CreateIfNotExists();
          
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<BankAsset> BankAssets { get; set; }
        public DbSet<Family> Familys { get; set; }
        public DbSet<Estate> Estates { get; set; }
    }
}
