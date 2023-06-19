using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Cinemaxx.Pages.UsuarioAdm
{
    public class CreateModel : PageModel
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
            usuarioAdm.confirmarSenha = Request.Form["confirmarSenha"];


            if (usuarioAdm.nome.Length == 0 || usuarioAdm.email.Length == 0 || 
                usuarioAdm.senha.Length == 0 || usuarioAdm.confirmarSenha.Length == 0)
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
                        commad.Parameters.AddWithValue("@nome", usuarioAdm.nome);
                        commad.Parameters.AddWithValue("@email", usuarioAdm.email);
                        commad.Parameters.AddWithValue("@senha", usuarioAdm.senha);
                        commad.Parameters.AddWithValue("@confirmarSenha", usuarioAdm.confirmarSenha);

                        commad.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            usuarioAdm.nome = " "; usuarioAdm.email = " "; usuarioAdm.senha = " "; usuarioAdm.confirmarSenha = " ";
            successMessage = "Cadastro realizado com sucesso";

            Response.Redirect("/UsuarioAdm/IndexAdm");
        }
    }
}
