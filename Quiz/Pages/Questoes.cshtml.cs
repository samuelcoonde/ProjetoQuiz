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

        [BindProperty]
        public DateTime? RespostaPergunta4 { get; set; }

        [BindProperty]
        public string? RespostaPergunta5 { get; set; }

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
            if(RespostaPergunta4 < DateTime.Now)
            {
                DateTime dataDotNet = new DateTime(2002, 2, 13);
                if(RespostaPergunta4 == dataDotNet)
                {
                    QtdAcertos++;
                }
            }
            if(RespostaPergunta5 != null)
            {
                if (RespostaPergunta5.ToUpper().Equals("SELECT"))
                {
                    QtdAcertos++;
                }
            }
        }

        public int Acertos()
        {
            return QtdAcertos;
        }
    }
}
