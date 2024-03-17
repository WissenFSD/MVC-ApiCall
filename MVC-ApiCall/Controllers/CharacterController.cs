using Microsoft.AspNetCore.Mvc;
using MVC_ApiCall.Service;

namespace MVC_ApiCall.Controllers
{
    public class CharacterController : Controller
    {

        public IRickAndMortyService _rickandmortyService;

        public CharacterController(IRickAndMortyService service)
        {
            _rickandmortyService = service;
        }
        public IActionResult Index()
        {

            var characters = _rickandmortyService.GetCharacters();

            return View(characters);
          
        }
    }
}
