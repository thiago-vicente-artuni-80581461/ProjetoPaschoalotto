using ProjetoPaschoalotto.Web.Models;

namespace ProjetoPaschoalotto.Web.Services.Interface
{
    public interface IUsuarioService
    {
        List<Usuario> GetUsuarios();
        void SalvarUsuario(Usuario usuario);
    }
}
