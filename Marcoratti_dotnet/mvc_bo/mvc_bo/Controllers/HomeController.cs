using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_bo.Models;

namespace mvc_bo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlunoBLL _alunoBll;

        public HomeController(ILogger<HomeController> logger, IAlunoBLL alunoBll)
        {
            _logger = logger;
            _alunoBll = alunoBll;
        }

        public IActionResult Index()
        {
            List<Aluno> alunos = _alunoBll.GetAlunos().ToList();
            return View("Lista", alunos);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _alunoBll.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        //get
        public IActionResult Edit(int id)
        {
            Aluno aluno = _alunoBll.GetAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _alunoBll.AtualizarAluno(aluno);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _alunoBll.DeletarAluno(aluno);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            Aluno aluno = _alunoBll.GetAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
