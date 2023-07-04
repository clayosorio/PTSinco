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
		[HttpGet]
		public IActionResult GetAsignaturas() 
		{
			var res = _asignaturasServices.GetAsignaturas();
			return Ok(res);
		}

		[HttpPost]
		public IActionResult AddAsignaturas(Asignaturas asignatura) 
		{
				 _asignaturasServices.AddAsignaturas(asignatura);
				return Ok();
		}
		[HttpPost]
		public IActionResult AddCalificacionWithProfesorAndAlumno(Calificaciones calificaciones)
		{
				_asignaturasServices.AddCalificacionWithProfesorAndAlumno(calificaciones);
				return Ok();
		}
		[HttpPut]
		public IActionResult AsignarProfesorAAsignatura(string identificacionProfesor, string codigoAsignatura)
		{
			_asignaturasServices.AsignarProfesorAAsignatura(identificacionProfesor, codigoAsignatura);
			return Ok();
		}

		[HttpPut]
		public IActionResult AgregarNotaToCalificacion(string identificacionProfesor, string identificacionAlumno, double calificacionFinal)
		{
				_asignaturasServices.AgregarNotaToCalificacion(identificacionProfesor, identificacionAlumno, calificacionFinal);
				return Ok();
		}

		[HttpGet]
		public IActionResult GetReporteNotas()
		{
			var res = _asignaturasServices.GetReporteNotas();
			return Ok(res);
		}

	}
}
