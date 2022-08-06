using APIs.Models;
using Microsoft.EntityFrameworkCore;

namespace APIs.Data
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> opt): base(opt)
        {

        }

        public DbSet<Pessoas> pessoas { get; set; }
        public DbSet<Livro> livros { get; set; }

    }
}
