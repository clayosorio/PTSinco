using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Repositories.IRepositories
{
	public interface IAsignaturasRepositories
	{
		Task AddAsignaturas(Asignaturas asignatura);
		Task AddAsgintauraToProfesor(Calificaciones calificaciones);
		Task AsignarProfesorAAsignatura(string identificacionProfesor, string codigoAsignatura);
	}
}
