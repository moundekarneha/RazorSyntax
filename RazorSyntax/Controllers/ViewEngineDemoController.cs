using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorSyntax.Controllers
{
    public class ViewEngineDemoController : Controller
    {
        // GET: ViewEngineDemo
        public ActionResult Index()
        {
            return View();
        }
    }
}