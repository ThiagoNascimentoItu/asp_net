using System;
using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    [Route("[controller]/[action]")]
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Saudacao"] = "Olá...";
            ViewData["DataInicio"] = new DateTime(2017,09,01);
            ViewData["Endereco"]= new Endereco()
            {
                Nome="Macoratti",
                Rua = "Rua Projetada, 100",
                Cidade = "Lins",
                Estado = "SP"
            };

            return View();
        }
    }
}