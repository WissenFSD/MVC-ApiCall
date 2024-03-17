using MVC_ApiCall.Models;
using MVC_ApiCall.Repository;

namespace MVC_ApiCall.Service
{


    public interface IRickAndMortyService
    {
        public List<Character> GetCharacters();
    }
    public class RickAndMortyService:IRickAndMortyService
    {
        public IRickAndMortyRepository _rickandmortyRepository;


        public RickAndMortyService(IRickAndMortyRepository repository)
        {
         
            _rickandmortyRepository = repository;   
        }
        public List<Character> GetCharacters()
        {

            // repository'e erişmemiz lazım

          return  _rickandmortyRepository.GetCharacters();

        }

    }
}
