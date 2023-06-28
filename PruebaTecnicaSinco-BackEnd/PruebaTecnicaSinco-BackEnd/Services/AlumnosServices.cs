using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
using PruebaTecnicaSinco_BackEnd.Services.IServices;

namespace PruebaTecnicaSinco_BackEnd.Services
{
	public class AlumnosServices : IAlumnosServices
	{
		IAlumnosRepositories _alumnosRepositories;
		public AlumnosServices(IAlumnosRepositories alumnosRepositories)
        {
			_alumnosRepositories = alumnosRepositories;
		}
        public void AddAlumnos(Alumnos alumno)
		{
			_alumnosRepositories.AddAlumnos(alumno);
		}
		public void UpdateAlumnos(Alumnos alumno)
		{
			_alumnosRepositories.UpdateAlumnos(alumno);
		}
		public void DeleteAlumnos(string identificacionAlumno)
		{
			_alumnosRepositories.DeleteAlumnos(identificacionAlumno);
		}
	}
}
