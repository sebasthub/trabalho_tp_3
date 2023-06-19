using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Cinemaxx.Pages.Sala.IndexModel;
using System.Data.SqlClient;

namespace Cinemaxx.Pages.Sala
{
    public class CreateModel : PageModel
    {
        //public Sala sala = new Sala();
        public String errorMessage = " ";
        public String successMessage = " ";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            //sala.numeroSala = Request.Form["numeroSala"];
            //sala.quantidadeCadeira = Request.Form["quantidadeCadeira"];
            //sala.tipoSala = Request.Form["tipoSala"];
            //sala.horario = Request.Form["horario"];
            //sala.disponibilidade = Request.Form["disponibilidade"];
            //sala.fileira = Request.Form["filiera"];
            //sala.numeroCadeira = Request.Form["numeroCadeira"];
            //sala.vagaPne = Request.Form["vagaPne"];

            //if (sala.numeroSala.Length == 0 || sala.quantidadeCadeira.Length == 0 || sala.tipoSala.Length == 0 || sala.horario.Length == 0
            // || sala.disponibilidade.Length == 0 || sala.fileira.Length == 0 || sala.numeroCadeira.Length == 0 || sala.vagaPne.Length == 0)
            //{
            //    errorMessage = "Todos os campos devem ser preenchidos";
            //    return;
            //}

            //try
            //{
            //    String connectionString = "Data Source=LAPTOP-R7T019C0\\\\MSQLBEATRIZ;Initial Catalog=topicos;Integrated Security=True\"";
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        String sql = "INSERT INTO sala " + " VALEUS " + ";";

            //        using (SqlCommand commad = new SqlCommand(sql, connection))
            //        {

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    errorMessage = ex.Message;
            //    return;
            //}

            //sala.numeroSala = " "; sala.quantidadeCadeira = " "; sala.tipoSala = " "; sala.horario = " ";
            //sala.disponibilidade = " "; sala.fileira = " "; sala.numeroCadeira = " "; sala.vagaPne = " ";
            //successMessage = "Cadastro realizado com sucesso";

            Response.Redirect("/Sala/Index");

        }
    }
}
