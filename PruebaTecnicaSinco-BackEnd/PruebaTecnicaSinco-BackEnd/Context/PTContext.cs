﻿using Microsoft.EntityFrameworkCore;
using PruebaTecnicaSinco_BackEnd.Models.ModelRequest;

namespace PruebaTecnicaSinco_BackEnd.Context
{
	public class PTContext : DbContext
	{
		public DbSet<Alumnos> Alumnos { get; set; }
		public DbSet<Asignaturas> Asignaturas { get; set; }
		public DbSet<Profesores> Profesores { get; set; }
		public DbSet<Calificaciones> Calificaciones { get; set; }

		public PTContext(DbContextOptions<PTContext> options) : base(options) { }
	}
}
