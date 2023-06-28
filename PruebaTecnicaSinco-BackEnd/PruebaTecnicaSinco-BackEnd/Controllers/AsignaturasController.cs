using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Services.IServices;

namespace PruebaTecnicaSinco_BackEnd.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class AsignaturasController : ControllerBase
	{
		IAsignaturasServices _asignaturasServices;
		public AsignaturasController(IAsignaturasServices asignaturasServices)
		{
			_asignaturasServices = asignaturasServices;
		}

		[HttpPost]
		public IActionResult AddAsignaturas(Asignaturas asignatura) 
		{
			_asignaturasServices.AddAsignaturas(asignatura);
			return Ok();
		}
		[HttpPost]
		public IActionResult AddAsgintauraToProfesor(Asignaturas asignatura)
		{
			_asignaturasServices.AddAsgintauraToProfesor(asignatura);
			return Ok();
		}

	}
}
