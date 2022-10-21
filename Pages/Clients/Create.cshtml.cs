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
            //clientInfo.Instruktør = Request.Form["Instruktør"];
            //clientInfo.Årstal = Request.Form["Årstal"];

            //if (clientInfo.FilmTitel.Length == 0 || clientInfo.Instruktør.Length == 0 ||
            //    clientInfo.Årstal.Length == 0)
            //{
            //    errorMessage = "Alle fælter skal være indtastet";
            //    return;
            //}

            //clientInfo.FilmTitel = ""; clientInfo.Instruktør = ""; clientInfo.Årstal = "";
            //SuccessMessage = "Ny film er tilføjet";
        }
    }
}
