using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitLife.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FitLife.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public IEnumerable<Aluno> _aluno = new Aluno[] {
            new Aluno(){
                AlunoId = 1,
                Nome = "Marcelo Carrer",
                CPF = "977.031.170-72",
                DataNasc = "17/08/1979",
                Foto = "foto.png",
                Ativo = true
            },
            new Aluno(){
                AlunoId = 2,
                Nome = "Liara T'Soni",
                CPF = "154.654.845-96",
                DataNasc = "01/02/1674",
                Foto = "foto.png",
                Ativo = true
            }
        };

        public AlunoController()
        {            
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _aluno;
        }

        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return _aluno.Where(a => a.AlunoId == id).FirstOrDefault();
        }
    }
}
