using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieWebsite.Pages.Clients
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public String errorMessage = "";
        public String SuccessMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            //clientInfo.FilmTitel = Request.Form["FilmTitel"];
            //clientInfo.Instrukt�r = Request.Form["Instrukt�r"];
            //clientInfo.�rstal = Request.Form["�rstal"];

            //if (clientInfo.FilmTitel.Length == 0 || clientInfo.Instrukt�r.Length == 0 ||
            //    clientInfo.�rstal.Length == 0)
            //{
            //    errorMessage = "Alle f�lter skal v�re indtastet";
            //    return;
            //}

            //clientInfo.FilmTitel = ""; clientInfo.Instrukt�r = ""; clientInfo.�rstal = "";
            //SuccessMessage = "Ny film er tilf�jet";
        }
    }
}
