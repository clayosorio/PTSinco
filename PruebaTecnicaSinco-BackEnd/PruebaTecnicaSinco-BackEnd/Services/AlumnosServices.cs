using Microsoft.IdentityModel.Tokens;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Models.ModelResponses;
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

		public IEnumerable<Alumnos> GetAlumnos()
		{
			var res = _alumnosRepositories.GetAlumnos();
			return res;
		}
		public IEnumerable<Alumnos> GetAlumnoByIdentificacion(string identificacionAlumno)
		{
			var res = _alumnosRepositories.GetAlumnoByIdentificacion(identificacionAlumno);
			return res;
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
