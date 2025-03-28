using ProjetoPaschoalotto.Models;
using ProjetoPaschoalotto.Respository.Interface;
using ProjetoPaschoalotto.Services.Interface;

namespace ProjetoPaschoalotto.Services
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public void SalvarUsuario(Usuario? listaUsuarios)
        {
            _usuarioRepository.SalvarUsuario(listaUsuarios);
        }

        public List<UsuarioRegistro> GetUsuarios()
        {
            return _usuarioRepository.GetUsuarios();
        }
    }
}
