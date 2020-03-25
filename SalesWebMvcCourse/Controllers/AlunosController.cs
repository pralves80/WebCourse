using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvcCourse.Models;

namespace SalesWebMvcCourse.Controllers
{
    public class AlunosController : Controller
    {
        public IActionResult Index()
        {
            List<Aluno> list = new List<Aluno>();
            list.Add(new Aluno { IdAluno_PK = 1, Matricula = 20200001, Nome = "Pietro", DataNascimento = Convert.ToDateTime("01/10/1980"), NomePai = "Carlos", NomeMae = "Nadira", NomeResponsavel = null, GrauResponsavel = null });
            list.Add(new Aluno { IdAluno_PK = 2, Matricula = 20200002, Nome = "Juliana", DataNascimento = Convert.ToDateTime("01/05/1980"), NomePai = "Nome do Pai", NomeMae = "Nome da Mae", NomeResponsavel = null, GrauResponsavel = null });

            return View(list);
        }
    }
}