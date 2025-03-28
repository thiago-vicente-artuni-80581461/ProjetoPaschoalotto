using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjetoPaschoalotto.Models;
using ProjetoPaschoalotto.Services;
using ProjetoPaschoalotto.Services.Interface;
using System.Text;

namespace ProjetoPaschoalotto.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    string apiUrl = "https://randomuser.me/api/";

    public readonly IUsuarioService _usuarioService;
    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet(Name = "Usu�rio")]
    public async Task<HttpResponseMessage> Get()
    {
        HttpResponseMessage response = null;

        using (HttpClient client = new HttpClient())
        {
            response = await client.GetAsync(apiUrl);

            string content = await response.Content.ReadAsStringAsync();

            var listaUsuarios = JsonConvert.DeserializeObject<Usuario>(content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Requisi��o enviada com sucesso!");

                _usuarioService.SalvarUsuario(listaUsuarios);
            }
            else
            {
                Console.WriteLine("Falha ao enviar a requisi��o. C�digo de status: " + response.StatusCode);
            }
        }
        return response;


    }
}
