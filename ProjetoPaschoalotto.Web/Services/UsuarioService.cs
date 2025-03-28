using ProjetoPaschoalotto.Web.Models;
using ProjetoPaschoalotto.Web.Respository.Interface;
using ProjetoPaschoalotto.Web.Services.Interface;


namespace ProjetoPaschoalotto.Web.Services
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuarioRepository.GetUsuarios();
        }

        public void SalvarUsuario(Usuario usuario)
        {
            _usuarioRepository.SalvarUsuario(usuario);
        }

    }
}
