using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Models.ModelResponses;

namespace PruebaTecnicaSinco_BackEnd.Services.IServices
{
	public interface IAsignaturasServices
	{
		IEnumerable<Asignaturas> GetAsignaturas();
		void AddAsignaturas(Asignaturas asignatura);
		void AddCalificacionWithProfesorAndAlumno(Calificaciones calificaciones);
		void AsignarProfesorAAsignatura(string identificacionProfesor, string codigoAsignatura);
		void AgregarNotaToCalificacion(string identificacionProfesor, string identificacionAlumno, double calificacionFinal);
		IEnumerable<CalificacionesResponse> GetReporteNotas();
	}
}
