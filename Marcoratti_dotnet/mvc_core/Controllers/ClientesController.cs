using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_core.Models;
using mvc_core.ViewModels;

namespace mvc_core.Controllers
{
    public class ClientesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult index(Cliente cliente)
        {
            return View("ExibirDados", cliente);
        }

        /*explicação sobre ViewModel*/
        //public IActionResult Detalhe()
        //{
        //    Cliente cliente = new Cliente
        //    {
        //        ClienteId = 100,
        //        Nome = "Thiago",
        //        Email = "thiago@gmail.com"
        //    };

        //    var pedidos = new List<Pedido>{

        //        new Pedido{ Nome = "Pedido 1"},
        //        new Pedido{ Nome = "Pedido 2"},
        //    };

        //    var viewModel = new ClientePedidoViewModel
        //    {
        //        Cliente = cliente,
        //        Pedidos = pedidos
        //    };

        //    return View(viewModel);
        //}
    }
}
