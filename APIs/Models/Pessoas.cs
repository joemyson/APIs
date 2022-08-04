using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Models
{
    public class Pessoas
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo obrigatorio")]
        public string Nome { get; set; }
     
        public int Telefone { get; set; }
        [Required(ErrorMessage ="Campo obrigatorio")]
        public string Apelido { get; set; }
    }
}
