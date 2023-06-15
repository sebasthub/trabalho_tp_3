using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemaxx.Pages.Sala
{
    public class EditModel : PageModel
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

            //if(Sala.numeroSala.Length == 0 || Sala.quantidadeCadeira.Length == 0 || Sala.tipoSala.Length == 0 || Sala.horario.Length == 0
            // || Sala.disponibilidade.Length == 0 || Sala.fileira.Length == 0 || Sala.numeroCadeira.Length == 0 || Sala.vagaPne.Length == 0)
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
            //        String sql = "UPDATE sala " + " SET " + "WHERE"
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

            // sala.numeroSala = " "; usala.quantidadeCadeira = " "; sala.tipoSala = " "; sala.horario = " ";
            // sala.disponibilidade = " "; sala.fileira = " "; sala.numeroCadeira = " "; sala.vagaPne = " ";
            //successMessage = "Sala Editada com sucesso";

            Response.Redirect("/Sala/Index");
        }
    }
}
