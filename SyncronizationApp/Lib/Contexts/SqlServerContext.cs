using Lib.DbObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Contexts
{
    public class SqlServerContext : DbContext
    {
        // 4 database tables
        public DbSet<DataEntry> DataEntries { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<UnitOfMeasure1> UnitsOfMeasure1 { get; set; }
        public DbSet<UnitOfMeasure2> UnitsOfMeasure2 { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=localhost,1434;database=NewDB;password=P@ssword!;user id=sa;encrypt=false");
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString;
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
