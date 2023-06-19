using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using static Cinemaxx.Pages.Usuario.IndexModel;

namespace Cinemaxx.Pages.Usuario
{
    public class EditModel : PageModel
    {
        public UsuarioInfo usuarioInfo = new UsuarioInfo();
        public String errorMessage = " ";
        public String successMessage = " ";
        public void OnGet()
        {
            String id = Request.Query["id"];

            try
            {
                String connectionString = "Data Source=LAPTOP-R7T019C0\\MSQLBEATRIZ;Initial Catalog=topicos;Integrated Security=True ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM Usuario WHERE id=@id ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UsuarioInfo usuarioInfo = new UsuarioInfo();
                                usuarioInfo.id = "" + reader.GetInt32(0);
                                usuarioInfo.nome = "" + reader.GetString(1);
                                usuarioInfo.email = "" + reader.GetString(2);
                                usuarioInfo.senha = "" + reader.GetString(3);
                                usuarioInfo.confirmarSenha = "" + reader.GetString(4);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }
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
                String connectionString = "Data Source=LAPTOP-R7T019C0\\MSQLBEATRIZ;Initial Catalog=topicos;Integrated Security=True ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "UPDATE UsuarioAdm " +
                                 "SET nome=@nome, email@=email, senha@senha, confirmarSenha@confirmarSenha)" +
                                 "WHERE id=@id;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UsuarioInfo usuarioInfo = new UsuarioInfo();
                                usuarioInfo.id = "" + reader.GetInt32(0);
                                usuarioInfo.nome = "" + reader.GetString(1);
                                usuarioInfo.email = "" + reader.GetString(2);
                                usuarioInfo.senha = "" + reader.GetString(3);
                                usuarioInfo.confirmarSenha = "" + reader.GetString(4);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            Response.Redirect("/Usuario/Index");
        }
    }
}
