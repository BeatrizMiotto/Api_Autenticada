using ApiAutenticada.Models;

namespace ApiAutenticada.ModelViews;

public class VeiculoRepositorio
{
    private VeiculoRepositorio()
    {
        ListaVeiculo = new List<Veiculos>();
    }
    public  List<Veiculos> ListaVeiculo = default!;

    private static VeiculoRepositorio? veiculoRepositorio;

    public static VeiculoRepositorio Instancia()
    {
        if(veiculoRepositorio is null) veiculoRepositorio = new VeiculoRepositorio();
        return veiculoRepositorio;
    }
    
}