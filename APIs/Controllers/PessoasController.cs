using APIs.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class Pessoascontroller : ControllerBase
    {

        private static List<Pessoas> pessoas = new List<Pessoas>();

        private static int id = 1;



        [HttpPost]
        public IActionResult AdicionarPessoas([FromBody] Pessoas pessoa)
        {

            pessoa.Id = id++;
            pessoas.Add(pessoa);

            return CreatedAtAction(nameof(RecuperaPessoasId), new { Id = pessoa.Id }, pessoa);


        }
        [HttpGet]
        public IEnumerable<Pessoas> RecuperaPessoas()
        {
            return pessoas;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPessoasId(int id)
        {
            Pessoas pessoa = pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if(pessoa != null)
            {
                return Ok(pessoa);
            }
            return NotFound();
        }
    }
}
