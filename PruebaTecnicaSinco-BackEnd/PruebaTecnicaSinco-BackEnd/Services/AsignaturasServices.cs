using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
using PruebaTecnicaSinco_BackEnd.Services.IServices;

namespace PruebaTecnicaSinco_BackEnd.Services
{
	public class AsignaturasServices : IAsignaturasServices
	{
        IAsignaturasRepositories _asignaturasRepositories;
        public AsignaturasServices(IAsignaturasRepositories asignaturasRepositories)
        {
			_asignaturasRepositories = asignaturasRepositories;
		}

		public void AddAsignaturas(Asignaturas asignatura)
		{
			_asignaturasRepositories.AddAsignaturas(asignatura);
		}
		public void AddAsgintauraToProfesor(Calificaciones calificaciones)
		{
			_asignaturasRepositories.AddAsgintauraToProfesor(calificaciones);
		}
		public void AsignarProfesorAAsignatura(string identificacionProfesor, string codigoAsignatura)
		{
			_asignaturasRepositories.AsignarProfesorAAsignatura(identificacionProfesor, codigoAsignatura);
		}
	}
}
