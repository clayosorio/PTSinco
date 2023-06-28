
CREATE OR ALTER PROCEDURE [Stored_Procedures].[UpdateAlumnos]
(
	@Identificacion NVARCHAR(450),
	@Nombre         NVARCHAR(MAX) = NULL, 
	@Apellido       NVARCHAR(MAX) = NULL,
	@Edad		    NVARCHAR(MAX) = NULL,
	@Direccion	    NVARCHAR(MAX) = NULL,
	@Telefono	    NVARCHAR(MAX) = NULL,
	@AnoAcademico   NVARCHAR(MAX) = NULL,
	@CodeAsignatura NVARCHAR(MAX) = NULL
)
AS 
BEGIN 
	SET NOCOUNT ON

		IF NOT EXISTS(SELECT TOP 1 Identificacion FROM Alumnos WHERE Identificacion = @Identificacion)
			BEGIN 
				THROW 51000, 'El Alumno a actualizar no se encuentra registrado, por favor validar la identificación', 1;
			END
		BEGIN 
			UPDATE 
				Alumnos
			SET
				Nombre         = @Nombre, 
				Apellido       = @Apellido,
				Edad           = @Edad,
				Direccion      = @Direccion, 
				Telefono	   = @Telefono,
				AnoAcademico   = @AnoAcademico,
				CodeAsignatura = @CodeAsignatura
		    WHERE
				Identificacion = @Identificacion
		END
END