using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBUY_MOD.DAL.Mappings;
using NBUY_MOD.Entities;

namespace NBUY_MOD.DAL.Database
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            
           this.Database.Connection.ConnectionString= @"Server =.; Database = NBUYMODDB; Trusted_Connection = True";
           var id = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new CategoryMappings());
        }
    }
}
