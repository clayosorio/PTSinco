using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Repositories.IRepositories
{
	public interface IProfesoresRepositories
	{
		IEnumerable<Profesores> GetProfesores();
		void AddProfesores(Profesores profesor);
		void UpdateProfesores(Profesores profesor);
	}
}
