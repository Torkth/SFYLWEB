using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SFYL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Members of Stroll For Your Life";

            return View();
        }

        public ActionResult ContactDetails(string name)
        {
            ViewBag.Message = name;
            return View("ContactDetails/" + name);   
        }
    }
}