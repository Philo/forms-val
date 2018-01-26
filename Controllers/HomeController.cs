using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

        public IActionResult IsUnique(string remote) 
        {
            return Json(remote?.Equals("valid") ?? false);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
