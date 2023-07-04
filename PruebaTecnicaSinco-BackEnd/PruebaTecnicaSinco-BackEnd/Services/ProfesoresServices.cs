using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;

namespace PruebaTecnicaSinco_BackEnd.Services.IServices
{
	public class ProfesoresServices : IProfesoresServices
	{
		private readonly IProfesoresRepositories _profesoresRepositories;
		public ProfesoresServices(IProfesoresRepositories profesoresRepositories)
        {
			_profesoresRepositories = profesoresRepositories;
		}

		public IEnumerable<Profesores> GetProfesores()
		{
			var res = _profesoresRepositories.GetProfesores();
			return res;
		}

		public void AddProfesores(Profesores profesor)
		{
			_profesoresRepositories.AddProfesores(profesor);
		}
		public void UpdateProfesores(Profesores profesor) 
		{
			_profesoresRepositories.UpdateProfesores(profesor);
		}
	}
}
