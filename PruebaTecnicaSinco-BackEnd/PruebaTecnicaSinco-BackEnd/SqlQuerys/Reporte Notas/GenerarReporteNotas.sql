
CREATE OR ALTER PROCEDURE [Stored_Procedures].[GenerarReporteNotas]
AS
BEGIN 
	SET NOCOUNT ON

		BEGIN  
			SELECT 
			cal.AnoAcademico,
			al.IdentificacionAlumno,
			cal.NombreAlumno,
			cal.CodigoAsignatura,
			cal.NombreAsignatura, 
			pr.IdentificacionProfesor,
			cal.NombreProfesor,
			cal.CalificacionFinal,
			cal.Aprobo
		FROM 
			Calificaciones as cal
		INNER JOIN 
				Alumnos as al ON al.IdentificacionAlumno = cal.IdentificacionAlumno
		INNER JOIN 
				Asignaturas as asi ON asi.CodigoAsignatura = cal.CodigoAsignatura
		INNER JOIN 
				Profesores as pr ON pr.IdentificacionProfesor = asi.IdentificacionProfesor
		WHERE cal.CalificacionFinal IS NOT NULL
		END
END