using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemaxx.Pages.Sala

{ //public List<> listSala = new List<Sala>();
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            //   try
            //    {
            //        String connectionString = "";
            //        using(SqlConnection connection = new SqlConnection Connection(connectionString))
            //                {
            //                   connectionString.Open();
            //            String sql = "SELECT * FROM SALA";
            //            using (SqlConnection connection = new SqlConnection Connection(connectionString)){
            //                using (SqlDataReader reader = command.ExecuteReader())
            //                {
            //                    while (reader.Read())
            //                    {

            //                    }
            //                }
            //            }

            //                }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Exception: " ex.ToString);
            //    }
            //}
        }

        public class Sala
        {
            public string id;
            public string quatidadeCadeira;
            public string tipoSala;
            public string horario;
            public string disponibilidade;
            public string fileiras;
            public string numeroCadeiras;
            public string vagaPne;

        }
    }
}

