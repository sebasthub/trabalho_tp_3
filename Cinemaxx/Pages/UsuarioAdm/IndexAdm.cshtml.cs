using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Cinemaxx.Pages.UsuarioAdm

{ 
    public class IndexAdmModel : PageModel
    {
        public List<UsuarioAdm> listUsuarioAdm = new List<UsuarioAdm>();
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
                                UsuarioAdm usuarioAdm = new UsuarioAdm();
                                usuarioAdm.id = "" + reader.GetInt32(0);
                                usuarioAdm.nome = "" + reader.GetString(1);
                                usuarioAdm.email = "" + reader.GetString(2);
                                usuarioAdm.senha = "" + reader.GetString(3);
                                usuarioAdm.confirmarSenha = "" + reader.GetString(4);

                                listUsuarioAdm.Add(usuarioAdm);
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

        public class UsuarioAdm
        {
            public string id;
            public string nome;
            public string email;
            public string senha;
            public string confirmarSenha;

        }
}
