using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnumSelectListMvcHelpers.Models;

namespace EnumSelectListMvcHelpers.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new HomeIndexViewModel());
        }

    }
}
