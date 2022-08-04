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

    public static List<Pessoas> pessoas = new List<Pessoas>();

    public void AdicionarPessoas([FromBody]Pessoas pessoa)
    {
        pessoas.Add(pessoa);
        Console.WriteLine(pessoa.Nome);

    }
    }
}
