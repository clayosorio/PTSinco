using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaSinco_BackEnd.Dapper;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Models.ModelResponses;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
using PruebaTecnicaSinco_BackEnd.Services.IServices;
using System.Data;

namespace PruebaTecnicaSinco_BackEnd.Services
{
	public class AsignaturasRepositories : IAsignaturasRepositories
	{
		private readonly string _connectionString;

		public AsignaturasRepositories(IConfiguration configuration)
		{
			_connectionString = configuration.GetConnectionString("DBPruebaSinco");
		}

		public void AddAsignaturas(Asignaturas asignatura)
		{
			var procedure = "[Stored_Procedures].[InsertAsignaturas]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Codigo = asignatura.CodigoAsignatura,
				Nombre = asignatura.Nombre
			};
			Task.Run(() => PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters)).Wait();
		}

		public void AddCalificacionWithProfesorAndAlumno(Calificaciones calificaciones)
		{
			var procedure = "[Stored_Procedures].[CreacionCalificaciones]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				AnoAcademico         = calificaciones.AnoAcademico,
				IdentificacionAlumno = calificaciones.IdentificacionAlumno,
				NombreAlumno         = calificaciones.NombreAlumno,
				CodigoAsignatura     = calificaciones.CodigoAsignatura,
				NombreAsignatura     = calificaciones.NombreAsignatura
			};

			Task.Run(() => PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters)).Wait();
		}

		public void AsignarProfesorAAsignatura(string identificacionProfesor, string codigoAsignatura)
		{
			var procedure = "[Stored_Procedures].[AsignarProfesorAAsignatura]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				IdentificacionProfesor = identificacionProfesor,
				CodigoAsignatura = codigoAsignatura
			};

			Task.Run(() => PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters)).Wait();
		}

		public void AgregarNotaToCalificacion(string identificacionProfesor, string identificacionAlumno, double calificacionFinal)
		{
			var procedure = "[Stored_Procedures].[AsignarNotaACalificacion]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				IdentificacionProfesor = identificacionProfesor,
				IdentificacionAlumno   = identificacionAlumno,
				CalificacionFinal      = calificacionFinal
			};
			Task.Run(() => PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters)).Wait();
		}

		public IEnumerable<CalificacionesResponse> GetReporteNotas()
		{
			var procedure = "[Stored_Procedures].[GenerarReporteNotas]";
			var command = CommandType.StoredProcedure;

			var result = PTDapper.ExecuteStoredProcedureAsync<CalificacionesResponse>(_connectionString, procedure, command);
			return result.Result;
		}
	}
}
