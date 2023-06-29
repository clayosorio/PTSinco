using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PruebaTecnicaSinco_BackEnd.Models.ModelRequest
{
    public class Asignaturas
    {
        [Key]
        public string CodigoAsignatura { get; set; }
        public string Nombre { get; set; }
        [JsonIgnore]
		public string? IdentificacionProfesor { get; set; }
	}
}
