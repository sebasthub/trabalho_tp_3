using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemaxx.Pages.UsuarioAdm

{//public List<> listUsuarioAdm = new List<UsuarioAdm>();
    public class IndexAdmModel : PageModel
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

        public class UsuarioIAdm
        {
            public string id;
            public string nome;
            public string email;
            public string senha;
            public string confirmarSenha;

        }
    }
}
