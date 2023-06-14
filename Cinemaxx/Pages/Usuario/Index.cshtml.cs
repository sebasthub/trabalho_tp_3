using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemaxx.Pages.Usuario
{
    //public List<> listUsuario = new List<UsuarioInfo>();
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
            //            String sql = "SELECT * FROM USUARIO";
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

        public class UsuarioInfo
        {
            public string id;
            public string nome;
            public string email;
            public string senha;

        }
    }
}
