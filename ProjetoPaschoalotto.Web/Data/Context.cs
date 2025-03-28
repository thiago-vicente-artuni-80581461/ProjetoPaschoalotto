using Microsoft.EntityFrameworkCore;
using ProjetoPaschoalotto.Web.Models;

namespace ProjetoPaschoalotto.Web.Data
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
