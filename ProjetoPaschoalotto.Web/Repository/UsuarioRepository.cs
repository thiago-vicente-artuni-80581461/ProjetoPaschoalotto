using ProjetoPaschoalotto.Web.Models;
using ProjetoPaschoalotto.Web.Data;
using ProjetoPaschoalotto.Web.Respository.Interface;

namespace ProjetoPaschoalotto.Web.Respository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public readonly Context _context;

        public UsuarioRepository(Context context)
        {
            _context = context;
        }

        public List<Usuario> GetUsuarios()
        {
            return _context.Usuario.ToList();
        }

        public void SalvarUsuario(Usuario usuario)
        {
            _context.Usuario.Update(usuario);
            _context.SaveChanges();
        }
    }
}
