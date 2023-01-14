namespace ApiAutenticada.Models;

public record Veiculos
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string? Descricao {get; set;}
    public string? Marca {get; set;}
    public string? Modelo {get; set;}
    public int Ano {get; set;}

} 