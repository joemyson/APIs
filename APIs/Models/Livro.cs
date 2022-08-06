using System.ComponentModel.DataAnnotations;

namespace APIs.Models
{
    public class Livro
    {
        [Key]
        [Required]
        public int Id{ get; set; }
        [Required(ErrorMessage ="Campo Obrigatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage ="Campo Obrigatorio")]
        public string Titulo{ get; set; }
    }
}
