using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NBUY_MOD.Entities;
using NBUY_MOD.Services;

namespace NBUY_MOD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<News> list=new NewsServices().GetAll();
            return View(list);
        }
    }
}