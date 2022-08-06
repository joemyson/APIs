using APIs.Models;
using Microsoft.EntityFrameworkCore;

namespace APIs.Data
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> opt):base(opt)
        {

        }
        public DbSet<Livro> livros { get; set; }
    }
}
