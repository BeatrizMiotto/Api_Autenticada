using ApiAutenticada.Models;
using ApiAutenticada.ModelViews;
using Microsoft.AspNetCore.Mvc;

namespace ApiAutenticada.Controller;

[Route("veiculos")]
public class ClientesController : ControllerBase
{
    [HttpGet("")]
    public IActionResult Index()
    {
        var veiculos = VeiculoRepositorio.Instancia().ListaVeiculo;
        return StatusCode(200,  veiculos);
    }

    [HttpGet("{id}")]
    public IActionResult Details([FromRoute] int id)
    {
       var veiculo = VeiculoRepositorio.Instancia().ListaVeiculo.Find(c => c.Id == id);

        return StatusCode(200, veiculo);
    }

    [HttpPost("")]
    public IActionResult Create([FromBody] Veiculos veiculos)
    {
        VeiculoRepositorio.Instancia().ListaVeiculo.Add(veiculos);
        return StatusCode(201, veiculos);
    }

    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] Veiculos veiculos)
    {
        if (id != veiculos.Id)
        {
            return StatusCode(400, new {
                Mensagem = "Erro"
            });
        }

       var veiculoDb = VeiculoRepositorio.Instancia().ListaVeiculo.Find(c => c.Id == id);
       if(veiculoDb is null)
       {
            return StatusCode(404, new {
                Mensagem = "O veiculo não existe"
            });
        }

        veiculoDb.Nome = veiculos.Nome;
        veiculoDb.Descricao = veiculos.Descricao;
        veiculoDb.Marca = veiculos.Marca;
        veiculoDb.Modelo = veiculos.Modelo;
        veiculoDb.Ano = veiculos.Ano;

        return StatusCode(200, veiculoDb);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var veiculoDb = VeiculoRepositorio.Instancia().ListaVeiculo.Find(c => c.Id == id);
        if(veiculoDb is null)
        {
            return StatusCode(404, new {
                Mensagem = "O veiculo não existe"
            });
        }

        VeiculoRepositorio.Instancia().ListaVeiculo.Remove(veiculoDb);

        return RedirectToAction(nameof(Index));
    }
}