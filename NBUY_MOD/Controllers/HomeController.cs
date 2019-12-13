using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NBUY_MOD.Entities;
using NBUY_MOD.Models;
using NBUY_MOD.Services;

namespace NBUY_MOD.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsServices _newsServices;
        private readonly CategoryServices _categoryServices;
        private HomeIndexViewModel _homeIndexViewModel;

        public HomeController()
        {
            _newsServices=new NewsServices();
            _categoryServices=new CategoryServices();
            _homeIndexViewModel = new HomeIndexViewModel();
        }
        // GET: Home
        public ActionResult Index()
        {
            _homeIndexViewModel.News = _newsServices.GetAll();
            _homeIndexViewModel.Categories = _categoryServices.GetAll();

            return View(_homeIndexViewModel);
        }
    }
}