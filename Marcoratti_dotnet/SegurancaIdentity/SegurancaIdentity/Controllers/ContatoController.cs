using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SegurancaIdentity.Data;

namespace SegurancaIdentity.Controllers
{
    [Authorize]
    public class ContatoController : Controller
    {
        private ApplicationDbContext _context;

        public ContatoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult AcessoAutorizado()
        {
            return Content("Acesso autorizado...");
        }
        [AllowAnonymous]
        public IActionResult AcessoAnonimo()
        {
            return Content("Acesso anonimo...");
        }
    }
}
