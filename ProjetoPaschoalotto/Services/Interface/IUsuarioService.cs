using ProjetoPaschoalotto.Models;

namespace ProjetoPaschoalotto.Services.Interface
{
    public interface IUsuarioService
    {
        void SalvarUsuario(Usuario? listaUsuarios);
        List<UsuarioRegistro> GetUsuarios();
    }
}
