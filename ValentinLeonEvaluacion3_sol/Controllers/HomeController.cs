using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace valentinPrueba_n3_leon.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Musica()
        {
            return View();
        }
    }
}