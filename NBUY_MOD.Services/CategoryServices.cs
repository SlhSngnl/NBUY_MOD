using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBUY_MOD.DAL.Repositories;
using NBUY_MOD.Entities;

namespace NBUY_MOD.Services
{
    public class CategoryServices
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryServices()
        {
            _categoryRepository=new CategoryRepository();
        }

        public List<Category> GetAll()
        {
            List<Category> categories = _categoryRepository.GetAll();
            return categories;
        }
    }
}
