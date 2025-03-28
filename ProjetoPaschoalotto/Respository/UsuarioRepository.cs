using ProjetoPaschoalotto.Data;
using ProjetoPaschoalotto.Models;
using ProjetoPaschoalotto.Respository.Interface;

namespace ProjetoPaschoalotto.Respository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public readonly Context _context;

        public UsuarioRepository(Context context)
        {
            _context = context;
        }
        public void SalvarUsuario(Usuario? listaUsuarios)
        {
            UsuarioRegistro usuarioNovo = new UsuarioRegistro
            {
                Email = listaUsuarios.Results[0].Email,
                City = listaUsuarios.Results[0].Location.City,
                Country = listaUsuarios.Results[0].Location.Country,
                First = listaUsuarios.Results[0].Name.First,
                Last = listaUsuarios.Results[0].Name.Last,
                Phone = listaUsuarios.Results[0].Phone,
                Large = listaUsuarios.Results[0].Picture.Large
            };

            _context.Usuario.Add(usuarioNovo);
            _context.SaveChanges();
        }

        public List<UsuarioRegistro> GetUsuarios()
        {
            return _context.Usuario.ToList();
        }
    }
}
