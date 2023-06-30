using Microsoft.Extensions.Configuration;
using PruebaTecnicaSinco_BackEnd.Dapper;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
using System.ComponentModel.Design;
using System.Data;

namespace PruebaTecnicaSinco_BackEnd.Services.IServices
{
	public class ProfesoresRepositories : IProfesoresRepositories
	{
		private readonly string _connectionString;

        public ProfesoresRepositories(IConfiguration configuration)
        {
			_connectionString = configuration.GetConnectionString("DBPruebaSinco");
		}

		public async Task AddProfesores(Profesores profesor) 
		{
			var procedure = "[Stored_Procedures].[InsertProfesores]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Identificacion = profesor.IdentificacionProfesor,
				Nombre         = profesor.Nombre,
				Apellido       = profesor.Apellido,
				Edad           = profesor.Edad,
				Direccion      = profesor.Direccion,
				Telefono       = profesor.Telefono
			};
			try
			{
				await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
			}
			catch (Exception ex) { throw (ex); }

		}

		public async Task UpdateProfesores(Profesores profesor)
		{
			var procedure = "[Stored_Procedures].[UpdateProfesores]";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Identificacion = profesor.IdentificacionProfesor,
				Nombre = profesor.Nombre,
				Apellido = profesor.Apellido,
				Edad = profesor.Edad,
				Direccion = profesor.Direccion,
				Telefono = profesor.Telefono
			};
			try
			{
				await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
			}
			catch (Exception ex) { throw (ex); }
			
		}
    }
}
