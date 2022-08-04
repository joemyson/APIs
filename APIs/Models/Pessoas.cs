using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Models
{
    public class Pessoas
    {
        [Required(ErrorMessage ="Campo obrigatorio")]
        public string Nome { get; set; }
        [Range(1,10,ErrorMessage ="o numero deve conter enter 1 e 10 digitos")]
        public int Telefone { get; set; }
        [Required(ErrorMessage ="Campo obrigatorio")]
        public string Apelido { get; set; }
    }
}
