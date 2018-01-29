using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using forms_val.Models;

namespace forms_val.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(HomeModel model)
        {
            return View("View", model);
        }

        public IActionResult IsUnique(string remote, string emailAddress)
        {
            if (remote?.EndsWith("@stormid.com") ?? false)
            {
                return Json(true);
            }
            return Json("The field must end with '@stormid.com'");
        }

        public IActionResult Fluent()
        {
            var model = new FVHomeModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Fluent(FVHomeModel model)
        {
            return View("ViewFluent", model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
