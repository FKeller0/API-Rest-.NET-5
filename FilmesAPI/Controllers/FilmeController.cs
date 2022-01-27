using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> Filmes = new();
        private static int Id = 1;

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme) 
        {
            filme.Id = Id++;
            Filmes.Add(filme);            
        }

        [HttpGet]
        public IEnumerable<Filme> RetornaFilmes() 
        {
            return Filmes;
        }

        [HttpGet("{id}")]
        public Filme RetornaFilmesPorId(int id) 
        {
            return Filmes.FirstOrDefault(x => x.Id == id);
        }

    }
}
