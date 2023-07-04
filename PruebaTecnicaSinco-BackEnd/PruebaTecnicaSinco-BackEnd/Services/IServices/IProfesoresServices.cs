using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Services.IServices
{
	public interface IProfesoresServices
	{
		IEnumerable<Profesores> GetProfesores();
		void AddProfesores(Profesores profesor);
		void UpdateProfesores(Profesores profesor);
	}
}
