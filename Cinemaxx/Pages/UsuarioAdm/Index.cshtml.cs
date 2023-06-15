using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemaxx.Pages.UsuarioAdm
{
    public class IndexModel : PageModel
    {
        //public UsuarioInfo usuarioInfo = new UsuarioInfo();
        public String errorMessage = " ";
        public String successMessage = " ";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            //usuarioInfo.nome = Request.Form["nome"];
            //usuarioInfo.email = Request.Form["email"];
            //usuarioInfo.senha = Request.Form["senha"];


            //if(Usuario.nome.Length == 0 || Usuario.email.Length == 0 || Usuario.senha.Length == 0 )
            //{
            //    errorMessage = "Todos os campos devem ser preenchidos";
            //    return;
            //}

            //try
            //{
            //    String connectionString = " ";
            //    using (SqlConnection connection = new SqlConnection Connection(connectionString))
            //    {
            //        connection.Open();
            //        String sql = "INSERT INTO usuario " + " VALEUS " + ";" ;

            //        using(SqlCommand commad = new SqlCommand(sql, connection))
            //        {

            //        }
            //    }
            //}
            //catch
            //{
            //    errorMessage = ex.Message;
            //    return
            //}

            // usuarioInfo.nome = " "; usuarioInfo.email = " "; usuarioInfo.senha = " "; 
            //successMessage = "Cadastro realizado com sucesso";

            Response.Redirect("/UsuarioAdm/IndexAdm");
        }
    }
}
