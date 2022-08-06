using APIs.Data;
using APIs.Data.DTO;
using APIs.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace APIs.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class Pessoascontroller : ControllerBase
    {



        private PessoaContext _context;
        private IMapper _mapper;

        public Pessoascontroller(PessoaContext context, IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
             

        }

        [HttpPost]
        public IActionResult AdicionarPessoas([FromBody] PessoaDTO pessoaDTO)
        {

            Pessoas pessoa = _mapper.Map<Pessoas>(pessoaDTO);

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
                ReadPessoaDTO PessoaDto = _mapper.Map<ReadPessoaDTO>(pessoa);
                return Ok(pessoa);
            }
            return NotFound();
        }


        [HttpPut]
        public IActionResult AtualizarPessoa(int id, [FromBody] UpDatePessoaDTO PessoaDTO)
        {
            Pessoas pessoa = _context.pessoas.FirstOrDefault(pessoa => pessoa.Id == id);

            if(pessoa == null)
            {
                return NotFound();
            }

            _mapper.Map(PessoaDTO, pessoa);
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
           
            return NoContent();
        }




    }
}
