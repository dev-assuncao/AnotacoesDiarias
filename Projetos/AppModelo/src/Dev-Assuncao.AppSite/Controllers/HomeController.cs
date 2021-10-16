using Microsoft.AspNetCore.Mvc;
using Dev_Assuncao.AppSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Assuncao.AppSite.Controllers
{
    public class HomeController : Controller
    {

        // private readonly IPedidoRepository _pedidoRepository;


        //public HomeController(IPedidoRepository pedidoRepository)
        //{
        //_pedidoRepository = pedidoRepository;
        //}
        public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
        {
            var pedido = _pedidoRepository.ObterPedido();
            return View();
        }
    }
}
