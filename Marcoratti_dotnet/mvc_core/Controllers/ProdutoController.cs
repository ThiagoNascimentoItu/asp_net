using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class ProdutoController : Controller
    {
        public string Index()
        {

            var https = HttpContext.Request.IsHttps;
            var caminho = HttpContext.Request.Path;
            var status = HttpContext.Response.StatusCode;
            var conexao = HttpContext.Connection.ToString();

            return https + "\r\n" + caminho + "\r\n" + status + "\r\n" + conexao;
            //return "Este é o método Action padrão. ";
        }

        public IActionResult Detalhe()
        {

            //var pessoa =  new { ID = 1, Nome = "Macoratti" };
            //return new ObjectResult(pessoa);
            //return File("images/banner1.svg","image/svg+xml");
            //return Content("arquivo PDF", "application/pdf");
            //return RedirectToAction("Index","Home",new {pagina=1, ordem="nome"});
            return View();
        }

        [Route("produto/lancamentos/{ano:int}/{mes:range(1,12)}")]
        public IActionResult DataLancamento(int ano, int mes)
        {
            return Content( ano + "/" + mes);
        }
    }
}