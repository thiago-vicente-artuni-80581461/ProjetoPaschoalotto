using Microsoft.AspNetCore.Mvc;
using ProjetoPaschoalotto.Web.Models;
using ProjetoPaschoalotto.Web.Services.Interface;

namespace ProjetoPaschoalotto.Web.Controllers
{
    public class CadastroUsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public CadastroUsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult CadastroUsuario(int id)
        {
            var recuperarUsuario = _usuarioService.GetUsuarios().Where(th => th.Id == id).FirstOrDefault();
            return View(recuperarUsuario);
        }

        [HttpPost]
        public IActionResult SalvarUsuario(Usuario usuario)
        {
            _usuarioService.SalvarUsuario(usuario);
            return RedirectToAction("IndexUsuario", "Relatorio");
        }
    }
}
