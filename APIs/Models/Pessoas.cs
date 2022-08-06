using System.ComponentModel.DataAnnotations;

namespace APIs.Models
{
    public class Pessoas
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo obrigatorio")]
        public string Nome { get; set; }     
        public int Telefone { get; set; }
        [Required(ErrorMessage ="Campo obrigatorio")]
        public string Apelido { get; set; }
    }
}
