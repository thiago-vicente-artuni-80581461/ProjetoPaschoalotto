using ProjetoPaschoalotto.Services.Interface;

namespace GeradorRelatorioUsuario.Controller
{
    public class ReportController
    {
        public readonly IUsuarioService usuarioService;

        public ReportController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }


    }
}
