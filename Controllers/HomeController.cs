using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CasaMateriaisConstrucao.Models;

namespace CasaMateriaisConstrucao.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
