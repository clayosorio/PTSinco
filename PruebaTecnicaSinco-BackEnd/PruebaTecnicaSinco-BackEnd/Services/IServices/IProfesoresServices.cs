using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Services.IServices
{
	public interface IProfesoresServices
	{
		void AddProfesores(Profesores profesor);
		void UpdateProfesores(Profesores profesor);
	}
}
