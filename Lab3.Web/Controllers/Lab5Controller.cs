using Microsoft.AspNetCore.Mvc;
using Lab3.Lib;
using Lab3.Web.Models;

namespace Lab3.Web.Controllers
{
    public class Lab5Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double R, double alfa)
        {
            double result = Circular_Sector.Calc(R, alfa);
            ViewBag.Result = result;
            return View();
        }

    }
}
