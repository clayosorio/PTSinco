using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaSinco_BackEnd.Dapper;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Models.ModelResponses;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
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

		public async Task AddAsignaturas(Asignaturas asignatura)
		{
			var procedure = "[Stored_Procedures].[InsertAsignaturas]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Codigo = asignatura.CodigoAsignatura,
				Nombre = asignatura.Nombre
			};
			try
			{
				await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
			}
			catch (Exception ex) { throw (ex); }

		}

		public async Task AddCalificacionWithProfesorAndAlumno(Calificaciones calificaciones)
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

			try
			{
				await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
			}
			catch (Exception ex) { throw (ex); }
		}

		public async Task AsignarProfesorAAsignatura(string identificacionProfesor, string codigoAsignatura)
		{
			var procedure = "[Stored_Procedures].[AsignarProfesorAAsignatura]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				IdentificacionProfesor = identificacionProfesor,
				CodigoAsignatura = codigoAsignatura
			};

			try
			{
				await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
			}
			catch (Exception ex) { throw (ex); }
		}

		public async Task AgregarNotaToCalificacion(string identificacionProfesor, string identificacionAlumno, double calificacionFinal)
		{
			var procedure = "[Stored_Procedures].[AsignarNotaACalificacion]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				IdentificacionProfesor = identificacionProfesor,
				IdentificacionAlumno   = identificacionAlumno,
				CalificacionFinal      = calificacionFinal
			};
			try
			{
				await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
			}
			catch (Exception ex) { throw (ex); }		
		}

		public async Task<IEnumerable<CalificacionesResponse>> GetReporteNotas()
		{
			var procedure = "Stored_Procedures.GenerarReporteNotas";
			var command = CommandType.StoredProcedure;
			
			var result = await PTDapper.ExecuteStoredProcedureAsync<CalificacionesResponse>(_connectionString, procedure, command);
			return result;
		}
	}
}
