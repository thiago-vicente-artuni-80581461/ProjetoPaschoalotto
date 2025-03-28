using Microsoft.EntityFrameworkCore;
using ProjetoPaschoalotto.Models;

namespace ProjetoPaschoalotto.Data
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<UsuarioRegistro> Usuario { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
