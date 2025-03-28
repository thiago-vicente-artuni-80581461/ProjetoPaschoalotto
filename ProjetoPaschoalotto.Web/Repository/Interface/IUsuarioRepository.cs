using ProjetoPaschoalotto.Web.Models;

namespace ProjetoPaschoalotto.Web.Respository.Interface
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetUsuarios();
        void SalvarUsuario(Usuario usuario);
    }
}
