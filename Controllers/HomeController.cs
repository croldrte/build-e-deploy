using Microsoft.AspNetCore.Mvc;

namespace CasaMateriaisDeConstrucao.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("nossa-historia")]
        public IActionResult NossaHistoria()
        {
            return View();
        }

        [Route("carreiras")]
        public IActionResult Carreiras()
        {
            return View();
        }

        [Route("contato")]
        public IActionResult Contato()
        {
            return View();
        }
    }
}