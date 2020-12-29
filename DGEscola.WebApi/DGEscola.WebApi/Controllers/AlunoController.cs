using DGEscola.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGEscola.WebApi.Controllers
{
    //necessário começar
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public Aluno Post([FromBody] Aluno aluno)
        {

            return aluno;
        }
    }
}
