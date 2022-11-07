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
        private static int id = 1;


        [HttpPost]
        public IActionResult AdicionarFilme([FromBody]Filme filme) //FromBody criado no corpo da requisição
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmesPorId), new { Id = filme.Id }, filme);
            // CreatedAtAction: Qual é a ação que criou esse recurso, passamos a action com seu nome'nameof' 

        }

        [HttpGet]
        public IActionResult RecuperarFilmes() 
        {
            return Ok(filmes);    
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmesPorId(int id) 
        {
            Filme filme = filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme != null) 
            {
                Ok(filme);
            }
            return NotFound();
        }

    }
}
