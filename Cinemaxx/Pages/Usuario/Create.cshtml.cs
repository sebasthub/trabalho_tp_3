using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using static Cinemaxx.Pages.Usuario.IndexModel;

namespace Cinemaxx.Pages.Usuario
{
    public class CreateModel : PageModel
    {
        public UsuarioInfo usuarioInfo = new UsuarioInfo();
        public String errorMessage = " ";
        public String successMessage = " ";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            usuarioInfo.nome = Request.Form["nome"];
            usuarioInfo.email = Request.Form["email"];
            usuarioInfo.senha = Request.Form["senha"];
            usuarioInfo.confirmarSenha = Request.Form["confirmarSenha"];


            if (usuarioInfo.nome.Length == 0 || usuarioInfo.email.Length == 0 ||
                usuarioInfo.senha.Length == 0 || usuarioInfo.confirmarSenha.Length == 0)
            {
                errorMessage = "Todos os campos devem ser preenchidos";
                return;
            }

            try
            {
                String connectionString = "Data Source=LAPTOP-R7T019C0\\\\MSQLBEATRIZ;Initial Catalog=topicos;Integrated Security=True\"";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO UsuarioAdm " +
                                 "(nome, email, senha, confirmarSenha) VALEUS " +
                                 "(@nome, @email, @senha, @confirmarSenha);";

                    using (SqlCommand commad = new SqlCommand(sql, connection))
                    {
                        commad.Parameters.AddWithValue("@nome", usuarioInfo.nome);
                        commad.Parameters.AddWithValue("@email", usuarioInfo.email);
                        commad.Parameters.AddWithValue("@senha", usuarioInfo.senha);
                        commad.Parameters.AddWithValue("@confirmarSenha", usuarioInfo.confirmarSenha);

                        commad.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            usuarioInfo.nome = " "; usuarioInfo.email = " "; 
            usuarioInfo.senha = " "; usuarioInfo.confirmarSenha = " ";
            successMessage = "Cadastro realizado com sucesso";

            Response.Redirect("/Usuario/Index");
        }
    }
}
