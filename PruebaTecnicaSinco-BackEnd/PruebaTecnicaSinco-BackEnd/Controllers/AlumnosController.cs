using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
using PruebaTecnicaSinco_BackEnd.Services.IServices;

namespace PruebaTecnicaSinco_BackEnd.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class AlumnosController : ControllerBase
	{
        IAlumnosServices _alumnosServices;
        public AlumnosController(IAlumnosServices alumnosServices)
        {
			_alumnosServices = alumnosServices;
        }
        [HttpPost]
        public IActionResult AddAlumnos(Alumnos alumno)
        {
		   _alumnosServices.AddAlumnos(alumno);
            return Ok();
        }
		[HttpPut]
		public IActionResult UpdateAlumnos(Alumnos alumno)
		{
			_alumnosServices.UpdateAlumnos(alumno);
			return Ok();
		}
		[HttpDelete]
        public IActionResult DeleteAlumnos(string identificacionAlumno) 
        {
			_alumnosServices.DeleteAlumnos(identificacionAlumno);
			return Ok();
		}
	}
}
