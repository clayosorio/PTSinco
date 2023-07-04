using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Models.ModelResponses;

namespace PruebaTecnicaSinco_BackEnd.Services.IServices
{
	public interface IAlumnosServices
	{
		void AddAlumnos(Alumnos alumno);
		void UpdateAlumnos(Alumnos alumno);
		void DeleteAlumnos(string identificacionAlumno);
		IEnumerable<Alumnos> GetAlumnos();
		IEnumerable<Alumnos> GetAlumnoByIdentificacion(string identificacionAlumno);
	}
}
