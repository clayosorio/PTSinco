﻿
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaSinco_BackEnd.Models.ModelRequest
{
    public class Calificaciones
    {
          [Key]
          public Guid?   IdCalificaciones { get; set; }
          public string  AnoAcademico { get; set; }
          public string  IdentificacionAlumno { get; set; }
          public string  NombreAlumno { get; set; }
          public string  CodigoAsignatura { get;set;}
	      public string  NombreAsignatura { get; set; }
          public string?  IdentificacionProfesor { get; set; }
          public string?  NombreProfesor { get; set; }
          public string?  CalificacionFinal {get; set; }
          public string? Aprobo { get; set; }
    }
}
