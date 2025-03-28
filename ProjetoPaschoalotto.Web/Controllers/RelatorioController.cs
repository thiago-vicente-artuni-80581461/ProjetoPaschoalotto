
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.AspNetCore.Mvc;
using ProjetoPaschoalotto.Web.Services.Interface;

namespace ProjetoPaschoalotto.Web.Controllers;

public class RelatorioController : Controller
{

    private readonly IUsuarioService _usuarioService;

    public RelatorioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public async Task<IActionResult> GerarRelatorio()
    {
        var lista = _usuarioService.GetUsuarios();

        var memoryStream = new MemoryStream();

        var writer = new PdfWriter(memoryStream);
        var pdf = new PdfDocument(writer);
        var document = new Document(pdf);

        document.Add(new Paragraph("Relatório de Usuários"));

        var table = new Table(8); 

        table.AddHeaderCell("Id");
        table.AddHeaderCell("Email");
        table.AddHeaderCell("Cidade");
        table.AddHeaderCell("País");
        table.AddHeaderCell("Nome");
        table.AddHeaderCell("Sobrenome");
        table.AddHeaderCell("Telefone");
        table.AddHeaderCell("Foto");

        foreach (var pedido in lista)
        {
            table.AddCell(pedido.Id.ToString());
            table.AddCell(pedido.Email);
            table.AddCell(pedido.City);
            table.AddCell(pedido.Country);
            table.AddCell(pedido.First);
            table.AddCell(pedido.Last);
            table.AddCell(pedido.Phone);
            table.AddCell(pedido.Large);
        }

        document.Add(table);
        document.Close();

        return File(memoryStream.ToArray(), "application/pdf", "relatorio_usuarios.pdf");

    }

    [HttpGet]
    public IActionResult IndexUsuario()
    {
        return View();
    }

    public IActionResult ListaUsuarios()
    {
        var lista = _usuarioService.GetUsuarios();
        return Json(lista);
    }
    [HttpGet]
    public IActionResult EditarUsuario(int id)
    {
        return Json(id);
    }

}
