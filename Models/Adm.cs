namespace ApiAutenticada.Models;

public record Adm
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string Email {get; set;} = default!;
    public string User {get; set;} = default!;
    public string senha {get; set;} = default!;
    public string regra {get; set;} = default!;
}