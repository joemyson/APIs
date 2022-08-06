using APIs.Data;
using APIs.Data.DTO;
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



        private PessoaContext _context;

        public Pessoascontroller(PessoaContext context)
        {
            _context = context;
             

        }

        [HttpPost]
        public IActionResult AdicionarPessoas([FromBody] PessoaDTO pessoaDTO)
        {

            Pessoas pessoa = new Pessoas
            {
              Apelido = pessoaDTO.Apelido,
              Nome = pessoaDTO.Nome,
              Telefone = pessoaDTO.Telefone

            };

            _context.pessoas.Add(pessoa);
            _context.SaveChanges();
            
            return CreatedAtAction(nameof(RecuperaPessoasId), new { Id = pessoa.Id }, pessoa);


        }
        [HttpGet]
        public IActionResult RecuperaPessoas()
        {
            return Ok(_context.pessoas);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPessoasId(int id)
        {
            Pessoas pessoa = _context.pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if(pessoa != null)
            {
                return Ok(pessoa);
            }
            return NotFound();
        }


        [HttpPut]
        public IActionResult AtualizarPessoa(int id, [FromBody] Pessoas NovaPessoa)
        {
            Pessoas pessoa = _context.pessoas.FirstOrDefault(pessoa => pessoa.Id == id);

            if(pessoa == null)
            {
                return NotFound();
            }
            pessoa.Id = NovaPessoa.Id;
            pessoa.Nome = NovaPessoa.Nome;
            pessoa.Telefone = NovaPessoa.Telefone;
            pessoa.Apelido = NovaPessoa.Apelido;
            _context.SaveChanges();

            return NoContent();
        }


        [HttpDelete]
        public IActionResult DeletarPessoa(int id, [FromBody] Pessoas NovaPessoa)
        {
            Pessoas pessoa = _context.pessoas.FirstOrDefault(pessoa => pessoa.Id == id);

            if (pessoa == null)
            {
                return NotFound();
            }

            _context.SaveChanges();
            _context.SaveChanges();
            return NoContent();
        }




    }
}
