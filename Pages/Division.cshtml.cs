public class DividirModel : PageModel
{
    [BindProperty]
    public double Numero1 { get; set; }

    [BindProperty]
    public double Numero2 { get; set; }

    public double? Resultado { get; set; }

    public void OnPost()
    {
        Resultado = Numero2 != 0 ? (double?)(Numero1 / Numero2) : null;
    }
}
