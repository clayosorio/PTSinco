using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace PruebaTecnicaSinco_BackEnd.Dapper
{
	public static class PTDapper
	{
		public static async Task<IEnumerable<T>> ExecuteStoredProcedureAsync<T>(
		   string _connectionString,
		   string storedProcedureName,
		   CommandType commandType,
		   object? parameters = null)
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				var result = await connection.QueryAsync<T>(
					sql: storedProcedureName,
					param: parameters,
					commandType: commandType
				);
				return result;
			}
		}

		public static async Task ExecuteStoredProcedureAsyncVoid(
			string _connectionString,
			string storedProcedureName,
			CommandType commandType,
			object? parameters = null)
		{
			using (var connection = new SqlConnection(_connectionString))
			{
				await connection.ExecuteAsync(
				sql: storedProcedureName,
				param: parameters,
				commandType: commandType
			);
			}
		}
	}
}
