using Microsoft.AspNetCore.Mvc;
using MVC_ApiCall.Models;
using MVC_ApiCall.Service;
using System.Diagnostics;

namespace MVC_ApiCall.Controllers
{
    public class HomeController : Controller
    {
        public IRickAndMortyService _rickandmortyService;

        public HomeController(IRickAndMortyService service)
        {
            _rickandmortyService = service;
         
        }

        public IActionResult Index()
        {

            // bir mvc uygulamasından api'ye istek atmak için RestCharp kullanılmaktadır.

            // RestSharp.RestClient cli = new RestSharp.RestClient();


           var characters =  _rickandmortyService.GetCharacters();

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