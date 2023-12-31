CREATE OR ALTER PROCEDURE [Stored_Procedures].[DeleteAlumnoByIdentificacion]
(
	@IdentificacionAlumno VARCHAR(250)
)
AS
BEGIN 
	SET NOCOUNT ON
		
	 IF NOT EXISTS (SELECT TOP 1 IdentificacionAlumno FROM Alumnos WHERE IdentificacionAlumno = @IdentificacionAlumno)
		BEGIN 
			THROW 51000, 'El alumno que intenta eliminar no se ecuentra registrado, por favor validar que la identificación sea la correcta', 1;
		END
	
	 IF EXISTS (
			SELECT TOP 1 
						AL.IdentificacionAlumno
			FROM 
				Alumnos AL
			INNER JOIN 
					Calificaciones CA 
					ON AL.IdentificacionAlumno = CA.IdentificacionAlumno
			WHERE 
				Al.IdentificacionAlumno = @IdentificacionAlumno
		)	
		BEGIN 
			THROW 51000, 'El alumno que intenta eliminar no puede ser eliminado debido a que tiene asignaturas asignadas', 1;
		END
			BEGIN 
				DELETE Alumnos
				WHERE
					IdentificacionAlumno = @IdentificacionAlumno
			END
END