using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Repositories.IRepositories
{
	public interface IAlumnosRepositories
	{
		void AddAlumnos(Alumnos alumno);
		void UpdateAlumnos(Alumnos alumno);
		void DeleteAlumnos(string identificacionAlumno);
	}
}
