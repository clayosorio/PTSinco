
CREATE OR ALTER PROCEDURE [Stored_Procedures].[GenerarReporteNotas]
AS
BEGIN 
	SET NOCOUNT ON

		BEGIN 
		SELECT 
			cal.AnoAcademico,
			al.IdentificacionAlumno,
			al.Nombre,
			cal.CodigoAsignatura,
			cal.NombreAsignatura, 
			pr.IdentificacionProfesor,
			pr.Nombre,
			cal.CalificacionFinal,
			cal.Aprobo
		FROM 
			Alumnos as al
		INNER JOIN 
				Calificaciones as cal ON al.IdentificacionAlumno = cal.IdentificacionAlumno
		INNER JOIN 
				Asignaturas as asi ON asi.CodigoAsignatura = cal.CodigoAsignatura
		INNER JOIN 
				Profesores as pr ON pr.IdentificacionProfesor = asi.IdentificacionProfesor
		END
END