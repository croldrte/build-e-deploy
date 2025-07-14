using Microsoft.AspNetCore.Mvc;

namespace CasaMateriaisDeConstrucao.Controllers
{
    [Route("produtos")]
    public class ProdutosController : Controller
    {
        [Route("")]
        public IActionResult Produtos()
        {
            return View();
        }

        [Route("para-sua-construcao")]
        public IActionResult ParaSuaConstrucao()
        {
            return View("ParaSuaConstrucao");
        }
        [Route("materiais-hidraulicos")]
        public IActionResult MateriaisHidraulicos()
        {
            var produtos = _context.Produtos.Where(p => p.Categoria == "Materiais Hidráulicos").ToList();
            return View(produtos);
        }

        [Route("materiais-eletricos")]
        public IActionResult MateriaisEletricos()
        {
            return View("MateriaisEletricos");
        }

        [Route("tintas")]
        public IActionResult Tintas()
        {
            return View("Tintas");
        }

        [Route("vernizes")]
        public IActionResult Vernizes()
        {
            return View("Vernizes");
        }

        [Route("esmaltes")]
        public IActionResult Esmaltes()
        {
            return View("Esmaltes");
        }

        [Route("ferramentas")]
        public IActionResult Ferramentas()
        {
            return View("Ferramentas");
        }

        [Route("pisos-e-revestimentos")]
        public IActionResult PisosERevestimentos()
        {
            return View("PisosERevestimentos");
        }

        [Route("metais")]
        public IActionResult Metais()
        {
            return View("Metais");
        }

        [Route("portas")]
        public IActionResult Portas()
        {
            return View("Portas");
        }

        [Route("janelas")]
        public IActionResult Janelas()
        {
            return View("Janelas");
        }
    }
}