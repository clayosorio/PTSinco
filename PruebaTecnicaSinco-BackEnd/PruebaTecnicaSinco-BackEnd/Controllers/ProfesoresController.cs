using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
using PruebaTecnicaSinco_BackEnd.Services.IServices;

namespace PruebaTecnicaSinco_BackEnd.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class ProfesoresController : Controller
	{
		IProfesoresServices _profesoresServices;
		public ProfesoresController(IProfesoresServices profesoresServices)
		{
			_profesoresServices = profesoresServices;

		}

		[HttpGet]
		public IActionResult GetProfesores() 
		{
			var res = _profesoresServices.GetProfesores();
			return Ok(res);
		}
		[HttpPost]
		public IActionResult AddProfesores(Profesores profesor)
		{
			_profesoresServices.AddProfesores(profesor);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateProfesores(Profesores profesor)
		{
			_profesoresServices.UpdateProfesores(profesor);
			return Ok();
		}
	}
}
