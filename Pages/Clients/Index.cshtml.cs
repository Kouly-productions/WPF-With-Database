using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace MovieWebsite.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public List<ClientInfo> listClients = new List<ClientInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=10.0.4.110;Initial Catalog=Movie;User ID=Work;Password=Test123";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Film";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.FilmID = reader.GetInt32(0);
                                clientInfo.FilmTitel = reader.GetString(1);
                                clientInfo.Instruktør = reader.GetString(2);
                                clientInfo.Årstal = reader.GetInt32(3);

                                listClients.Add(clientInfo);
                            }
                       }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }

    public class ClientInfo
    {
        public int FilmID;
        public string FilmTitel;
        public string Instruktør;
        public int Årstal;
    }
}
