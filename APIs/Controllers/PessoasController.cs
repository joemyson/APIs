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
    public void AdicionarPessoas([FromBody]Pessoas pessoa)
    {
        
        pessoa.Id = id++; 
        pessoas.Add(pessoa);
      

    }
        [HttpGet]
        public IEnumerable<Pessoas> RecuperaPessoas()
        {
            return pessoas;
        }
    }
}
