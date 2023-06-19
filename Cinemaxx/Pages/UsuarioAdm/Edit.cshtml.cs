using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Cinemaxx.Pages.UsuarioAdm
{
    public class EditModel : PageModel
    {
        public UsuarioAdm usuarioAdm = new UsuarioAdm();
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
                    String sql = "SELECT * FROM UsuarioAdm WHERE id=@id ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("id", id);  
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UsuarioAdm usuarioAdm = new UsuarioAdm();
                                usuarioAdm.id = "" + reader.GetInt32(0);
                                usuarioAdm.nome = "" + reader.GetString(1);
                                usuarioAdm.email = "" + reader.GetString(2);
                                usuarioAdm.senha = "" + reader.GetString(3);
                                usuarioAdm.confirmarSenha = "" + reader.GetString(4);

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
                                UsuarioAdm usuarioAdm = new UsuarioAdm();
                                usuarioAdm.id = "" + reader.GetInt32(0);
                                usuarioAdm.nome = "" + reader.GetString(1);
                                usuarioAdm.email = "" + reader.GetString(2);
                                usuarioAdm.senha = "" + reader.GetString(3);
                                usuarioAdm.confirmarSenha = "" + reader.GetString(4);

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

            Response.Redirect("/UsuarioAdm/Index");
        }
    }
}
