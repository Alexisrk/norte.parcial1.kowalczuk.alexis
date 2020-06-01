using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace norte.parcial1.kowalczuk.alexis.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        // GET: Home
        public ActionResult Cosmos()
        {
          return View();
        }
    }
}