using MemoryDemo_DesktopAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemoryDemo_DesktopAsp.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            Utilities.GetPageTrackingId();
        }
    }
}