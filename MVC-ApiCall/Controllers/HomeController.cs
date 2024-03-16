using Microsoft.AspNetCore.Mvc;
using MVC_ApiCall.Models;
using System.Diagnostics;

namespace MVC_ApiCall.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            // bir mvc uygulamasından api'ye istek atmak için RestCharp kullanılmaktadır.

           // RestSharp.RestClient cli = new RestSharp.RestClient();

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