using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Data.DTO
{
    public class LivroDTO
    {
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Titulo { get; set; }
    }
}
