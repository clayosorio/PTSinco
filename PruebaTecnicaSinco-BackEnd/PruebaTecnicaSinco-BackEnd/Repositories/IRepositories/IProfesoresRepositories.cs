using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Repositories.IRepositories
{
	public interface IProfesoresRepositories
	{
		void AddProfesores(Profesores profesor);
		void UpdateProfesores(Profesores profesor);
	}
}
