using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MemberProfilte()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MemberProfile()
        {
            return View();
        }
    }
}