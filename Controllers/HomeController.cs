using Microsoft.AspNetCore.Mvc;
using ApiAutenticada.ModelViews;

namespace api.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [Route("/")]
    [HttpGet]
    public ActionResult Index()
    {
        return StatusCode(200, new Home{
            Mensagem = "Bem vindo a minha API"
        });
    }
}