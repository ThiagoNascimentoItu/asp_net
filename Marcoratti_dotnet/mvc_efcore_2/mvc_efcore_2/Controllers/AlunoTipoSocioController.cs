using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_efcore_2.Models;

namespace mvc_efcore_2.Controllers
{
    public class AlunoTipoSocioController : Controller
    {
        private readonly DbContextAluno _alunoContext;

        public AlunoTipoSocioController(DbContextAluno alunoContext)
        {
            _alunoContext = alunoContext;
        }

        public IActionResult Index()
        {
            var infoAluno = _alunoContext.Alunos.Include(t => t.TipoSocio);
            return View(infoAluno);
        }
    }
}
