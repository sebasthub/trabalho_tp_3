using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Cinemaxx.Pages.Usuario.IndexModel;

namespace Cinemaxx.Pages.Usuario
{
    public class CreateModel : PageModel
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
            //usuarioInfo.confirmarSenha = Request.Form["confirmarSenha"];

            //if(Usuario.nome.Length == 0 || Usuario.email.Length == 0 || Usuario.senha.Length == 0 || Usuario.confirmarSenha.Length == 0)
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

            // usuarioInfo.nome = " "; usuarioInfo.email = " "; usuarioInfo.senha = " "; usuarioInfo.confirmarSenha = " ";
            //successMessage = "Cadastro realizado com sucesso";

            Response.Redirect("/Usuario/Index");
        }
    }
}
