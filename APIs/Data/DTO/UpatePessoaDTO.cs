using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Data.DTO
{
    public class UpDatePessoaDTO
    {
        
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Nome { get; set; }
        public int Telefone { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Apelido { get; set; }
    }
}
