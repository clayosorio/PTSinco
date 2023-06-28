using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaSinco_BackEnd.Models.ModelRequest
{
    public class Asignaturas
    {
        [Key]
        public string CodigoAsignatura { get; set; }
        public string Nombre { get; set; }
        public string? IdentificacionProfesor { get; set; }
        public Profesores Profesor { get; set; }

	}
}
