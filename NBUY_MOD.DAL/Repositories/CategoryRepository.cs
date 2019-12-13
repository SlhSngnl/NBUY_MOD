using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBUY_MOD.DAL.Database;
using NBUY_MOD.Entities;

namespace NBUY_MOD.DAL.Repositories
{
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            
            using (ProjectContext database=new ProjectContext())
            {
                List<Category> categories = database.Categories.ToList();
                return categories;
            }
        }
    }
}
