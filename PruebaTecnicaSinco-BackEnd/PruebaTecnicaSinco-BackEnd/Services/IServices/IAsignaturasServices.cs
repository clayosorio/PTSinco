using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Services.IServices
{
	public interface IAsignaturasServices
	{
		void AddAsignaturas(Asignaturas asignatura);
		void AddAsgintauraToProfesor(Asignaturas asignatura);
	}
}
