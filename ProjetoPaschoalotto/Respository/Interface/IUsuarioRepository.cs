using ProjetoPaschoalotto.Models;

namespace ProjetoPaschoalotto.Respository.Interface
{
    public interface IUsuarioRepository
    {
        List<UsuarioRegistro> GetUsuarios();
        void SalvarUsuario(Usuario? listaUsuarios);
    }
}
