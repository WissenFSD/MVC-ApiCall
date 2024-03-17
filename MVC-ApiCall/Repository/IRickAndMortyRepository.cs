using MVC_ApiCall.Models;
using RestSharp;
using Newtonsoft.Json;

namespace MVC_ApiCall.Repository
{
    public interface IRickAndMortyRepository
    {
        public List<Character> GetCharacters();

    }


    public class RickAndMortyRepository : IRickAndMortyRepository
    {
        public List<Character> GetCharacters()
        {
            //RestCharp ile apiye istek atalım
            var restClient = new RestClient("https://rickandmortyapi.com/api");
            var restRequest = new RestRequest("character");
            var response = restClient.ExecuteGet(restRequest);



            //gelen json veriyi- benim istediğim tip'e çevirmek için bir paket kullanacağım

            // Paketin adı NewtonSoft.Json

            var characterResult = JsonConvert.DeserializeObject<CharacterResults>(response.Content);


            return characterResult.results;



        }
    }
}
