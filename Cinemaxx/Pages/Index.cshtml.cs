using Cinemaxx.Pages.Usuario;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Cinemaxx.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
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


            if (usuarioInfo.nome.Length == 0 || usuarioInfo.email.Length == 0 ||
                usuarioInfo.senha.Length == 0)
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
                        commad.Parameters.AddWithValue("@nome", usuarioInfo.nome);
                        commad.Parameters.AddWithValue("@email", usuarioInfo.email);
                        commad.Parameters.AddWithValue("@senha", usuarioInfo.senha);


                        commad.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            usuarioInfo.nome = " "; usuarioInfo.email = " "; usuarioInfo.senha = " ";
            successMessage = "Cadastro realizado com sucesso";

            Response.Redirect("/Usuario/Index");
        }
    }
}