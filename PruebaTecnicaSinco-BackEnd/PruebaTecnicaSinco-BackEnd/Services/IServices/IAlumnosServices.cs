using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Services.IServices
{
	public interface IAlumnosServices
	{
		public void AddAlumnos(Alumnos alumno);
		public void UpdateAlumnos(Alumnos alumno);
		public void DeleteAlumnos(string identificacionAlumno);
	}
}
