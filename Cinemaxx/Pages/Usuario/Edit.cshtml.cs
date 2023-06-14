using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemaxx.Pages.Usuario
{
    public class EditModel : PageModel
    {
        //public UsuarioInfo usuarioInfo = new UsuarioInfo();
        public String errorMessage = " ";
        public String successMessage = " ";
        public void OnGet()
        {
            String id = Request.Query["id"];

            try
            {

            }
            catch
            {
                //    errorMessage = ex.Message;
                //    return
            }
        }

        public void OnPost()
        {
            //usuarioInfo.nome = Request.Form["nome"];
            //usuarioInfo.email = Request.Form["email"];
            //usuarioInfo.senha = Request.Form["senha"];

            //if(Usuario.nome.Length == 0 || Usuario.email.Length == 0 || Usuario.senha.Length == 0 ||)
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
            //        String sql = "UPDATE usuario " + " SET " + "WHERE" ;

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

            Response.Redirect("/Usuario/Index");
        }
    }
}
