using CalcultorProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;

namespace CalcultorProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalcModel model)
        {
            if (ModelState.IsValid)s
            {
                model.result = model.Calculate();
                return View(model);
            }
            return View(model);
        }
       
    }
}
