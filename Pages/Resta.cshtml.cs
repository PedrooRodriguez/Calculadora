using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraApp.Pages
{
    public class RestaModel : PageModel
    {
        [BindProperty]
        public double Numero1 { get; set; }

        [BindProperty]
        public double Numero2 { get; set; }

        public double? Resultado { get; set; }

        public void OnPost()
        {
            // Realiza la resta
            Resultado = Numero1 - Numero2;
        }
    }
}
