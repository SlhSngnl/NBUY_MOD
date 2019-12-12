using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBUY_MOD.DAL.Database;
using NBUY_MOD.Entities;

namespace NBUY_MOD.DAL.Repositories
{
    public class NewsRepository
    {
        public List<News> GetAll()
        {
            List<News> list;
            using (ProjectContext database = new ProjectContext())
            {
                list = database.News.ToList();
            }

            return list;
        }

        public News GetById(int id)
        {
            News news;
            using (ProjectContext database=new ProjectContext())
            {
                news = GetAll().SingleOrDefault(x => x.Id == id);
            }

            return news;
        }

        public int Add(News news)
        {
            using (ProjectContext database=new ProjectContext())
            {
                database.News.Add(news);
                return database.SaveChanges();
            }
        }
        public int Update(News news)
        {
            using (ProjectContext database = new ProjectContext())
            {
                var entity = database.Entry(news);
                entity.State = System.Data.Entity.EntityState.Modified;
                return database.SaveChanges();
            }
        }
        public int Delete(News news)
        {
            using (ProjectContext database = new ProjectContext())
            {
                var entity = database.Entry(news);
                entity.State = System.Data.Entity.EntityState.Deleted;
                return database.SaveChanges();
            }
        }

    }
}
