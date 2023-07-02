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
			_connectionString = configuration.GetConnectionString("DBPruebaSinco");
		}

		public void AddAlumnos(Alumnos alumno)
		{
			var procedure = "[Stored_Procedures].[InsertAlumnos]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Identificacion = alumno.IdentificacionAlumno,
				Nombre         = alumno.Nombre,
				Apellido       = alumno.Apellido,
				Edad		   = alumno.Edad,	
				Direccion	   = alumno.Direccion,	
				Telefono	   = alumno.Telefono
			};
			Task.Run(() => PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters)).Wait();
		}
		public void UpdateAlumnos(Alumnos alumno)
		{
			var procedure = "[Stored_Procedures].[UpdateAlumnos]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Identificacion = alumno.IdentificacionAlumno,
				Nombre = alumno.Nombre,
				Apellido = alumno.Apellido,
				Edad = alumno.Edad,
				Direccion = alumno.Direccion,
				Telefono = alumno.Telefono
			};

			Task.Run(() => PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters)).Wait();
		}
		public void DeleteAlumnos(string identificacionAlumno)
		{
			var procedure = "[Stored_Procedures].[DeleteAlumnoByIdentificacion]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				IdentificacionAlumno = identificacionAlumno
			};
			Task.Run(() => PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters)).Wait();
		}
	}
}
