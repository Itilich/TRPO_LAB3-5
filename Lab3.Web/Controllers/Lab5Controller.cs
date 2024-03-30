using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index(IFormCollection collection)
        {
            return View();
        }

    }
}
