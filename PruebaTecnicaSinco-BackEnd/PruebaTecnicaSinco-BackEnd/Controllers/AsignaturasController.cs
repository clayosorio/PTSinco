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
		public IActionResult AddAsgintauraToProfesor(Calificaciones calificaciones)
		{
			try
			{
				_asignaturasServices.AddAsgintauraToProfesor(calificaciones);
				return Ok();
			}
			catch (Exception ex)
			{

				return BadRequest(ex.Message);
			}
		}
		[HttpPut]
		public IActionResult AsignarProfesorAAsignatura(string identificacionProfesor, string codigoAsignatura)
		{
			_asignaturasServices.AsignarProfesorAAsignatura(identificacionProfesor, codigoAsignatura);
			return Ok();
		}

	}
}
