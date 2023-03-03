using Lib.Core.EF.DbObjects;
using Microsoft.EntityFrameworkCore;

namespace Lib.Core.EF.DbContexts
{
    public class SqliteContext : DbContext
    {
        // NUGET INSTALLS (that should already be installed to this project):
        // Microsoft.EntityFrameworkCore
        // Microsoft.EntityFrameworkCore.Design
        // Microsoft.EntityFrameworkCore.Tools
        // Microsoft.EntityFrameworkCore.SqlServer (if you're using sql server)
        // Microsoft.EntityFrameworkCore.Sqlite (if you're using sqlite)

        // TO MAKE CHANGES TO SCHEMA:
        // enter the following in Package manager console:
        // 'Add-Migration [migration name] -context SqliteContext' -> will prompt you for a migration name
        // 'update-database -context SqliteContext' -> this will apply your migration and update the database
        //
        // -Russ

        // here are the 4 db sets (database tables) for our current schema
        public DbSet<DataEntry> DataEntries { get; set; }
        public DbSet<SynchronizationEntry> Synchronizations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;


            string connString = $"Data source = E:/offlineData.db";
            optionsBuilder.UseSqlite(connString);
        }
    }
}
