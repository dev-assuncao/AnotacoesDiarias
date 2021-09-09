using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class FilmesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
    }
}
