using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hotel.Atr.Web.Controllers
{
    public class SimpleController : IController
    {

        public void Execute(RequestContext requestContext)
        {
            requestContext.HttpContext.Response.Write("<h>Test</h>");
        }

}

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
    }
}