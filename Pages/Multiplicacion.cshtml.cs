using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraApp.Pages
{
    public class MultiplicacionModel : PageModel
    {
        [BindProperty]
        public double Num1 { get; set; }

        [BindProperty]
        public double Num2 { get; set; }

        public double? Result { get; set; }

        public void OnPost()
        {
            Result = Num1 * Num2;
        }
    }
}
