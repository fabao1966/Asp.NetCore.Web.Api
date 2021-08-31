using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "T'Challa",
                Sobrenome = "Pantera Negra",
                Tefefone = "1234567890"
            },
            new Aluno(){
                Id = 2,
                Nome = "Jack Napier",
                Sobrenome = "Coringa",
                Tefefone = "1234567890"
            },
            new Aluno(){
                Id = 3,
                Nome = "Diana Prince",
                Sobrenome = "Mulher Maravilha",
                Tefefone = "0987654321"
            }
        };
        public AlunoController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);

            if(aluno == null) return BadRequest("Aluno não encontrado!");

            return Ok(aluno);
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string  nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => 
                a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome)
            );

            if(aluno == null) return BadRequest("Aluno não encontrado!");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}