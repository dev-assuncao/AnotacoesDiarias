using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuAppMVC.Controllers
{
    public class FilmeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
