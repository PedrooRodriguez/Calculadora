using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculadora.Pages
{
    public class SumarModel : PageModel
    {
        [BindProperty]
        public double n1 {get; set; }
        [BindProperty]
        public double n2 {get; set; }
        public double resultado {get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            resultado = n1 + n2;
        }
    }
}