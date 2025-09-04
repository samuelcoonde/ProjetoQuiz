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
        public bool? RespostaPergunta3 { get; set; }

        [BindProperty]
        public bool? RespostaPergunta4 { get; set; }

        [BindProperty]
        public bool? RespostaPergunta5 { get; set; }

        [BindProperty]
        public bool? RespostaPergunta6 { get; set; }

        [BindProperty]
        public bool? RespostaPergunta7 { get; set; }

        [BindProperty]
        public string? RespostaPergunta8 { get; set; }

        [BindProperty]
        public string? RespostaPergunta9 { get; set; }


        [BindProperty]
        public DateTime? RespostaPergunta10 { get; set; }

        public int QtdAcertos { get; set; }

        public void OnGet()
        {
        }

        public void OnPostResponderPerguntas()
        {
            if (RespostaPergunta1 == true) QtdAcertos++;
            if (RespostaPergunta2 == true) QtdAcertos++;
            if (RespostaPergunta3 == true) QtdAcertos++;
            if (RespostaPergunta4 == true) QtdAcertos++;
            if (RespostaPergunta5 == true) QtdAcertos++;
            if (RespostaPergunta6 == true) QtdAcertos++;
            if (RespostaPergunta7 == true) QtdAcertos++;

            if (RespostaPergunta8 != null && RespostaPergunta8.Length < 100)
            {
                if (RespostaPergunta8.ToUpper().Equals("SELECT"))
                {
                    QtdAcertos++;
                }
            }
            if (RespostaPergunta9 != null && RespostaPergunta9.Length < 100)
            {
                if (RespostaPergunta9.ToLower().Equals("if"))
                {
                    QtdAcertos++;
                }
            }
            if (RespostaPergunta10 < DateTime.Now)
            {
                DateTime dataDotNet = new DateTime(2002, 2, 13);
                if (RespostaPergunta10 == dataDotNet)
                {
                    QtdAcertos++;
                }
            }

        }
    }
}
