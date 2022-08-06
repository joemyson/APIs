using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Data.DTO
{
    public class ReadLivroDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Titulo { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
