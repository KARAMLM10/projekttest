using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller
{
    public class appbuilder
    {
        public ApplicationDBContext appBuilder()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();

            var options = new DbContextOptionsBuilder<ApplicationDBContext>();
            var connectionString = config.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);
            using (var dbContext = new ApplicationDBContext(options.Options))
            {
                var dataInitiaizer = new DataInitializer();
                dataInitiaizer.MigrateAndSeed(dbContext);

                // Migrate har flyttats till dataInitializer class (BEST PRACTISE)
                //dbContext.Database.Migrate();
            }
            var dbContextRetuned = new ApplicationDBContext(options.Options);
            return dbContextRetuned;


        }
    }
}
