using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaSinco_BackEnd.Models.ModelRequest
{
    public class Profesores
    {
		[Key]
		public string IdentificacionProfesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
