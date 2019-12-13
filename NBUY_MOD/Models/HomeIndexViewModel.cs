using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NBUY_MOD.Entities;

namespace NBUY_MOD.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            News=new List<News>();
            Categories=new List<Category>();
        }
        public List<News> News { get; set; }
        public IList<Category> Categories { get; set; }
    }
}