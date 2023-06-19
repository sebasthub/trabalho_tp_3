using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using static Cinemaxx.Pages.Usuario.IndexModel;

namespace Cinemaxx.Pages.UsuarioAdm
{
    public class IndexModel : PageModel
    {
        public UsuarioAdm usuarioAdm = new UsuarioAdm();
        public String errorMessage = " ";
        public String successMessage = " ";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            usuarioAdm.nome = Request.Form["nome"];
            usuarioAdm.email = Request.Form["email"];
            usuarioAdm.senha = Request.Form["senha"];


            if (usuarioAdm.nome.Length == 0 || usuarioAdm.email.Length == 0 ||
                usuarioAdm.senha.Length == 0)
            {
                errorMessage = "Todos os campos devem ser preenchidos";
                return;
            }

            try
            {
                String connectionString = " ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO UsuarioAdm " +
                                 "(nome, email, senha,) VALEUS " +
                                 "(@nome, @email, @senha,;";

                    using (SqlCommand commad = new SqlCommand(sql, connection))
                    {
                        commad.Parameters.AddWithValue("@nome", usuarioAdm.nome);
                        commad.Parameters.AddWithValue("@email", usuarioAdm.email);
                        commad.Parameters.AddWithValue("@senha", usuarioAdm.senha);
                        

                        commad.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            usuarioAdm.nome = " "; usuarioAdm.email = " "; usuarioAdm.senha = " ";
            successMessage = "Cadastro realizado com sucesso";

            Response.Redirect("/UsuarioAdm/IndexAdm");
        }
    }
}
