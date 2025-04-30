using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculadora.Pages
{
    public class MultiplicacionModel : PageModel
    {
        [BindProperty]
        public double Numero1 {get; set; }
        [BindProperty]
        public double Numero2 {get; set; }
        public double Resultado {get; set; }
        public bool MostrarResultado {get; set; }
        public void OnGet()
        {
            //Inicializar si se necesita algo
        }
        public void Onpost()
        {
            Resultado = Numero1 * Numero2;
            MostrarResultado = true;
        }
    }
}