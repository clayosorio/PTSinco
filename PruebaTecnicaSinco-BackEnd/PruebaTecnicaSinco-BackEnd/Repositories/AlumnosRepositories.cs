using PruebaTecnicaSinco_BackEnd.Dapper;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
using System.Data;
using System.Security.Cryptography.Xml;

namespace PruebaTecnicaSinco_BackEnd.Services
{
	public class AlumnosRepositories : IAlumnosRepositories
	{
		private readonly string _connectionString;
		public AlumnosRepositories(IConfiguration configuration)
		{
			_connectionString = configuration.GetConnectionString("conecctionGoSell");
		}

		public async Task AddAlumnos(Alumnos alumno)
		{
			var procedure = "InsertAlumnos";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Identificacion = alumno.IdentificacionAlumno,
				Nombre         = alumno.Nombre,
				Apellido       = alumno.Apellido,
				Edad		   = alumno.Edad,	
				Dirección	   = alumno.Direccion,	
				Teléfono	   = alumno.Telefono
			};
			await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
		}
		public async Task UpdateAlumnos(Alumnos alumno)
		{
			var procedure = "UpdateAlumnos";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Identificacion = alumno.IdentificacionAlumno,
				Nombre = alumno.Nombre,
				Apellido = alumno.Apellido,
				Edad = alumno.Edad,
				Dirección = alumno.Direccion,
				Teléfono = alumno.Telefono
			};
			await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
		}
		public async Task DeleteAlumnos(string identificacionAlumno)
		{
			var procedure = "DeleteAlumnoByIdentificacion";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				IdentificacionAlumno = identificacionAlumno
			};
			await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
		}
	}
}
