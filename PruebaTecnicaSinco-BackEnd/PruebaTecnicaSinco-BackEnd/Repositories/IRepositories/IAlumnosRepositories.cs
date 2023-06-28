using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Repositories.IRepositories
{
	public interface IAlumnosRepositories
	{
		Task AddAlumnos(Alumnos alumno);
		Task UpdateAlumnos(Alumnos alumno);
		Task DeleteAlumnos(string identificacionAlumno);
	}
}
