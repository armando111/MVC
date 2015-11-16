using EasyPTC.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyPTC.Web.Controllers
{
    public class HomeController : Controller
    {
        private IList<string> data = new List<string>
        {
            "Pesho",
            "Gosho",
            "Ivan"
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var someData = new AboutPageModel();
            someData.Students = this.data;
            someData.Marks = new List<int>()
            {
                1,
                2,
                3
            };
            ViewBag.Students = someData;

            return View(someData);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}