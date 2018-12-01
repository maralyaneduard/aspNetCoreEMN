using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using coreWebEMN.Models;
using LoggerEMN;

namespace coreWebEMN.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Logger logger = new Logger();
            logger.Log("first log");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
