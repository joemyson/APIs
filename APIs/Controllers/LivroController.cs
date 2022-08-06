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
    public class LivroController : ControllerBase
    {

        private PessoaContext _context;
        private IMapper _mapper;


         
        public LivroController( PessoaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        [HttpPost]
        public IActionResult AdicionarLivro([FromBody] LivroDTO livroDTO)
        {

            Livro livro = _mapper.Map<Livro>(livroDTO);
            _context.livros.Add(livro);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaLivroId), new { Id = livro.Id },livro);

        }

        [HttpGet]
        public IActionResult RecuperaLivro()
        {
            return Ok(_context.livros);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaLivroId(int id)
        {
            Livro livro = _context.livros.FirstOrDefault(livro => livro.Id == id);
            if(livro!= null)
            {
                ReadLivroDTO livroDTO = _mapper.Map<ReadLivroDTO>(livro);
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult AtualizaLivro(int id,[FromBody]UpDateLivroDTO livroDTO)
        {
            Livro livro = _context.livros.FirstOrDefault(livro => livro.Id == id);
            if (livro == null)
            {
                return NotFound();
            }
            _mapper.Map(livroDTO, livro);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]

        public IActionResult DeletaLivro(int id,[FromBody] Livro NovoLivro) 
        {
            Livro livro = _context.livros.FirstOrDefault(livro => livro.Id == id);

            if (livro == null)
            {
                return NotFound();
            }
            _context.SaveChanges();
            return NoContent();

        }


             
    }
}
