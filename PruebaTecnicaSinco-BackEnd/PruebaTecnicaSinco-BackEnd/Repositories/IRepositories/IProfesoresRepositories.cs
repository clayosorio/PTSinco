using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Repositories.IRepositories
{
	public interface IProfesoresRepositories
	{
		Task AddProfesores(Profesores profesor);
		Task UpdateProfesores(Profesores profesor);
	}
}
