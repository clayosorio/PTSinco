using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaSinco_BackEnd.Models.ModelRequest
{
    public class Alumnos
    {
		[Key]
		public string IdentificacionAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string AnoAcademico { get; set; }
    }
}
