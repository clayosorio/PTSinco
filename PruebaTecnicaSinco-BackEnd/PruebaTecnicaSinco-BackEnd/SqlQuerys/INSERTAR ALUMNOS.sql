CREATE OR ALTER PROCEDURE [Stored_Procedures].[InsertAlumnos]
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
		IF EXISTS (SELECT TOP 1 IdentificacionAlumno FROM Alumnos WHERE IdentificacionAlumno = @Identificacion)
			BEGIN 
				THROW 51000, 'El alumno que intenta registrar ya se encuentra registrado', 1;
			END
			BEGIN 
				INSERT INTO Alumnos
				VALUES
				(
					@Identificacion,
					@Nombre,   
				 	@Apellido,  
	 				@Edad,		   
					@Direccion,	   
					@Telefono,	   
					@AnoAcademico,
					@CodeAsignatura
				)
			END
END