using Microsoft.EntityFrameworkCore;
using POC.Models;

namespace POC.Database
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Orders> Orders { get; set; }
        // once this line is written, go to tools - NuGet Package Manager - Package Manager Console - write a command "add-migration "Meaningful name"" (it creates a new table in the sql server).
        // the above step will create a migration folder in the project file only. In order to add it in the SQL server, write a command "update-database" which will create a table in the database.
        // this step will create a table in the database from VS using EF core which is installed using NuGet Package instead of opening SQL Server and create it manually.

        protected override void OnModelCreating(ModelBuilder objModelBuilder)
        {
            //creates a static record in the orders table using EF core.

            objModelBuilder.Entity<Orders>().HasData(
                new Orders { OrderId = 1, OrderName= "Iphone 13 Mobile", DisplayOrder = 1},
                new Orders { OrderId = 2, OrderName = "Iphone 13 Charger", DisplayOrder = 2 },
                new Orders { OrderId = 3, OrderName = "Iphone 13 Earphone", DisplayOrder = 3 }
                // once this line is written, go to tools - NuGet Package Manager - Package Manager Console - write a command "update-database" which will create record(s) in the database.
                );
        }
    }
}
