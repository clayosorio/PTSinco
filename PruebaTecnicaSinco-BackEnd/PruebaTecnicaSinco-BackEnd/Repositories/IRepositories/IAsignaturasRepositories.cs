using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Repositories.IRepositories
{
	public interface IAsignaturasRepositories
	{
		Task AddAsignaturas(Asignaturas asignatura);
		Task AddAsgintauraToProfesor(Asignaturas asignatura);
	}
}
