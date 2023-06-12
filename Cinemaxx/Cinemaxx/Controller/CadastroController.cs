using Cinemaxx.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace Cinemaxx.Controller
{
    public class CadastroController : ControllerContext
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Salvar (CadastroViewModel cadastro)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Sucesso");
            }

            return View("Cadastro", cadastro);
        }
    }
}
