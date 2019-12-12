using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBUY_MOD.Entities;

namespace NBUY_MOD.DAL.Mappings
{
    public class CategoryMappings:EntityTypeConfiguration<Category>
    {
        public CategoryMappings()
        {
            ToTable("Categories");
        }
    }
}
