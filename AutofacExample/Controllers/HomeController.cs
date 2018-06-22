using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacExample.Controllers
{
    public class HomeController : Controller
    {
        private ITestService testService;

        public HomeController(ITestService testService)
        {
            this.testService = testService;
        }

        public ActionResult Index()
        {
            var testMessage = testService.GetTestString();
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
    }
}