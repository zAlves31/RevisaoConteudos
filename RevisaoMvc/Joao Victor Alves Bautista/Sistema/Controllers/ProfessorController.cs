using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema.Contexts;
using Sistema.Models;

namespace Sistema.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly SistemaContext _context;

        public ProfessorController(SistemaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int? professorId = HttpContext.Session.GetInt32("ProfessorId");

            if (professorId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var professor = _context.Professores.Find(professorId);

            var turmas = _context.Turmas.Where(t => t.ProfessorId == professorId).ToList();

            ViewBag.NomeProfessor = professor!.Nome;

            return View(turmas);
        }


        [HttpPost]
        public IActionResult CadastrarTurma(string nomeTurma) 
        {
            int? professorId = HttpContext.Session.GetInt32("ProfessorId");

            var turma = 
                new Turma { 
                    Nome = nomeTurma, 
                    ProfessorId = professorId
                };

            _context.Turmas.Add(turma);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult ExcluirTurma(int turmaId)
        {
            var turma = _context.Turmas.Include(x => x.Atividades).FirstOrDefault(x => x.TurmaId == turmaId);

            if (turma!.Atividades.Any())
            {
                TempData["Mensagem"] = "Voce não pode excluir uma turma com atividades cadastradas";

                return RedirectToAction("Index");
            }


            _context.Turmas.Remove(turma);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
