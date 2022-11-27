using Microsoft.AspNetCore.Mvc;

namespace CadastroDoadores.Controllers
{
    public class DoadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Modificar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }
    }
}
