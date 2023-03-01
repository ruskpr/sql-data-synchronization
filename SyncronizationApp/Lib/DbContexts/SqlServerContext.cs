using Lib.DbObjects;
using Microsoft.EntityFrameworkCore;

namespace Lib.Contexts
{
    public class SqlServerContext : DbContext
    {
        // NUGET INSTALLS (that should already be installed to this project):
        // Microsoft.EntityFrameworkCore
        // Microsoft.EntityFrameworkCore.Design
        // Microsoft.EntityFrameworkCore.Tools
        // Microsoft.EntityFrameworkCore.SqlServer (if you're using sql server)
        // Microsoft.EntityFrameworkCore.Sqlite (if you're using sqlite)

        // TO MAKE CHANGES TO SCHEMA:
        // enter the following in Package manager console:
        // 'Add-Migration [migration name] -context SqlServerContext' -> will prompt you for a migration name
        // 'update-database -context SqlServerContext' -> this will apply your migration and update the database
        //
        // -Russ

        // here are the 4 db sets (database tables) for our current schema
        public DbSet<DataEntry> DataEntries { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<UnitOfMeasure1> UnitsOfMeasure1 { get; set; }
        public DbSet<UnitOfMeasure2> UnitsOfMeasure2 { get; set; }
        public DbSet<SynchronizationEntry> Synchronizations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString;
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
