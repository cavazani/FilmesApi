using FilmesApi.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace FilmesApi.Controllers 
{

    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        public static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicionarFilme([FromBody]Filme filme) 
        {
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }
    }
}
