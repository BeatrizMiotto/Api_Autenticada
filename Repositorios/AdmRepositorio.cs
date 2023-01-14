using ApiAutenticada.Models;

namespace ApiAutenticada.ModelViews;

public class AdmRepositorio
{
    private AdmRepositorio()
    {
        ListaAdm = new List<Adm>();
    }
    public  List<Adm> ListaAdm = default!;

    private static AdmRepositorio? admRepositorio;

    public static AdmRepositorio Instancia()
    {
        if(admRepositorio is null) admRepositorio = new AdmRepositorio();
        return admRepositorio;
    }
    
}