using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemaxx.Pages.UsuarioAdm
{
    public class EditModel : PageModel
    {
        //public UsuarioAdm usuarioAdm = new UsuarioAdm();
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
            //usuarioAdm.nome = Request.Form["nome"];
            //usuarioAdm.email = Request.Form["email"];
            //usuarioAdm.senha = Request.Form["senha"];
            //usuarioAdm.confirmarSenha = Request.Form["confirmarSenha"];

            //if(UsuarioAdm.nome.Length == 0 || UsuarioAdm.email.Length == 0 || UsuarioAdm.senha.Length == 0 || UsuarioAdm.confirmarSenha.Length == 0)
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

            Response.Redirect("/UsuarioAdm/Index");
        }
    }
}
