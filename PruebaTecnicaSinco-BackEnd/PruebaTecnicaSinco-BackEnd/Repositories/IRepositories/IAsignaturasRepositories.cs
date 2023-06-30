using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Models.ModelResponses;

namespace PruebaTecnicaSinco_BackEnd.Repositories.IRepositories
{
	public interface IAsignaturasRepositories
	{
		Task AddAsignaturas(Asignaturas asignatura);
		Task AddCalificacionWithProfesorAndAlumno(Calificaciones calificaciones);
		Task AsignarProfesorAAsignatura(string identificacionProfesor, string codigoAsignatura);
		Task AgregarNotaToCalificacion(string identificacionProfesor, string identificacionAlumno, double calificacionFinal);
		Task<IEnumerable<CalificacionesResponse>> GetReporteNotas();
	}
}
