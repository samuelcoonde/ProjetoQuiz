using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace Quiz.Pages
{
    public class QuestoesModel : PageModel
    {
        [BindProperty]
        public bool? RespostaPergunta1 { get; set; }

        [BindProperty]
        public bool? RespostaPergunta2 { get; set; }

        [BindProperty]
        public string? RespostaPergunta3 { get; set; }

        public int QtdAcertos { get; set; }

        public void OnGet()
        {
        }

        public void OnPostResponderPerguntas()
        {
            if(RespostaPergunta1 == false)
            {
                QtdAcertos++;
            }
            if(RespostaPergunta2 == true)
            {
                QtdAcertos++;
            }
            if(RespostaPergunta3 == "SQL")
            {
                QtdAcertos++;
            }
        }

        public int Acertos()
        {
            return QtdAcertos;
        }
    }
}
