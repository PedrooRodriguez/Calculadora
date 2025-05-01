using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraApp.Pages
{
    public class DivisionModel : PageModel
    {
        [BindProperty]
        public double Numero1 { get; set; }

        [BindProperty]
        public double Numero2 { get; set; }

        public double? Resultado { get; set; }

        public string Error { get; set; } = string.Empty;

        public void OnPost()
        {
            if (Numero2 == 0)
            {
                Error = "No se puede dividir entre cero.";
                Resultado = null;
            }
            else
            {
                Resultado = Numero1 / Numero2;
            }
        }
    }
}

