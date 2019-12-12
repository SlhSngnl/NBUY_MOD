using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBUY_MOD.DAL.Database;
using NBUY_MOD.DAL.Repositories;
using NBUY_MOD.Entities;

namespace NBUY_MOD.Services
{
    public class NewsServices
    {
        private readonly NewsRepository _newsRepository;
        public List<News> GetAll()
        {
            var newsList = _newsRepository.GetAll();
            return newsList;
        }
    }
}
