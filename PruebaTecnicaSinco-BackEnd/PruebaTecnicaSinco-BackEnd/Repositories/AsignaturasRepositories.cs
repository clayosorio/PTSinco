using PruebaTecnicaSinco_BackEnd.Dapper;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
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
			var procedure = "InsertAsignaturas";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Codigo = asignatura.CodigoAsignatura,
				Nombre = asignatura.Nombre
			};
			await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
		}

		public async Task AddAsgintauraToProfesor(Asignaturas asignatura)
		{
			var procedure = "AddAsgintauraToProfesor";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Codigo = asignatura.CodigoAsignatura,
				Nombre = asignatura.Nombre,
				IdentificacionProfesor = asignatura.IdentificacionProfesor
			};
			await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
		}
	}
}
