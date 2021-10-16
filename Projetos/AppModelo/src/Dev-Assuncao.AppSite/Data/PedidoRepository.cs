using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev_Assuncao.AppSite.Models;

namespace Dev_Assuncao.AppSite.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }
    }


    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
