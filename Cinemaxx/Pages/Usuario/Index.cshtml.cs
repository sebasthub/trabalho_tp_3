using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Cinemaxx.Pages.Usuario
{

    public class IndexModel : PageModel
    {
             public List<UsuarioInfo> listUsuarioInfo = new List<UsuarioInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=LAPTOP-R7T019C0\\MSQLBEATRIZ;Initial Catalog=topicos;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM UsuarioAdm";
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

                                listUsuarioInfo.Add(usuarioInfo);
                            }
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
           
        }
    }

        public class UsuarioInfo
        {
            public string id;
            public string nome;
            public string email;
            public string senha;
            public string confirmarSenha;

        }
    }
}
