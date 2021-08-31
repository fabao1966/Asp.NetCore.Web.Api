using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class ProfessorController : ControllerBase
    {

        public ProfessorController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professores: Diana Prince, Dick Tracy,  Lois Lane, Bruce Wayne,  T'Challa");
        }
    }
}