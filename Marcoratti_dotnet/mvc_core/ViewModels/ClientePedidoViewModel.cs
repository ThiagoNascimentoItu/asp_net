using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc_core.Models;

namespace mvc_core.ViewModels
{
    public class ClientePedidoViewModel
    {
        public Cliente Cliente { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
