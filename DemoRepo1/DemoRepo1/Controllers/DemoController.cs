using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoRepo1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {

            return View();
        }

        public int Add(int a,int b)
        {
            int c=a+b;
            return c;
        }
    }
}
