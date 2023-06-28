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
			var procedure = "InsertProfesores";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Identificacion = profesor.IdentificacionProfesor,
				Nombre         = profesor.Nombre,
				Apellido       = profesor.Apellido,
				Edad           = profesor.Edad,
				Dirección      = profesor.Direccion,
				Teléfono       = profesor.Telefono
			};
			await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
		}

		public async Task UpdateProfesores(Profesores profesor)
		{
			var procedure = "UpdateProfesores";
			var command = CommandType.StoredProcedure;
			var parameters = new
			{
				Identificacion = profesor.IdentificacionProfesor,
				Nombre = profesor.Nombre,
				Apellido = profesor.Apellido,
				Edad = profesor.Edad,
				Dirección = profesor.Direccion,
				Teléfono = profesor.Telefono
			};
			await PTDapper.ExecuteStoredProcedureAsyncVoid(_connectionString, procedure, command, parameters);
		}
    }
}
