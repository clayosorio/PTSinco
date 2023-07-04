using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Models.ModelResponses;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
using PruebaTecnicaSinco_BackEnd.Services.IServices;
using System.Security.Cryptography.Xml;

namespace PruebaTecnicaSinco_BackEnd.Services
{
	public class AsignaturasServices : IAsignaturasServices
	{
        IAsignaturasRepositories _asignaturasRepositories;
        public AsignaturasServices(IAsignaturasRepositories asignaturasRepositories)
        {
			_asignaturasRepositories = asignaturasRepositories;
		}

		public IEnumerable<Asignaturas> GetAsignaturas()
		{
			var res = _asignaturasRepositories.GetAsignaturas();
			return res;
		}

		public void AddAsignaturas(Asignaturas asignatura)
		{
			 _asignaturasRepositories.AddAsignaturas(asignatura);
		}
		public void AddCalificacionWithProfesorAndAlumno(Calificaciones calificaciones)
		{
			_asignaturasRepositories.AddCalificacionWithProfesorAndAlumno(calificaciones);
		}
		public void AsignarProfesorAAsignatura(string identificacionProfesor, string codigoAsignatura)
		{
			_asignaturasRepositories.AsignarProfesorAAsignatura(identificacionProfesor, codigoAsignatura);
		}

		public void AgregarNotaToCalificacion(string identificacionProfesor, string identificacionAlumno, double calificacionFinal)
		{
			_asignaturasRepositories.AgregarNotaToCalificacion(identificacionProfesor, identificacionAlumno, calificacionFinal);
		}

		public IEnumerable<CalificacionesResponse> GetReporteNotas()
		{ 
			var result = _asignaturasRepositories.GetReporteNotas();
			return result;
		}

	}
}
