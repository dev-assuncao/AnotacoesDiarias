using Microsoft.AspNetCore.Mvc;
using Dev_Assuncao.AppSite.Models;
using System;
using Dev_Assuncao.AppSite.Data;
using System.Linq;

namespace Dev_Assuncao.AppSite.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _meuDbContext;

        public TesteCrudController(MeuDbContext context)
        {
            _meuDbContext = context;
        }

        public IActionResult Index()
        {

            var aluno = new Aluno 
            { 
                Name = "Davisson",
                DataNascimento = DateTime.Now, 
                Email = "davisson@gmail.com" 
            };

            _meuDbContext.Alunos.Add(aluno);
            _meuDbContext.SaveChanges();

            var aluno2 = _meuDbContext.Alunos.Find(aluno.Id);

            var aluno3 = _meuDbContext.Alunos.FirstOrDefault(x => x.Email == "davisson@gmail.com");

            var aluno4 = _meuDbContext.Alunos.Where(x => x.Name == "Davisson");
            aluno.Name = "Joao";
            _meuDbContext.Alunos.Update(aluno);
            _meuDbContext.SaveChanges();

            _meuDbContext.Alunos.Remove(aluno);
            _meuDbContext.SaveChanges();

            return View();
        }
    }
}
