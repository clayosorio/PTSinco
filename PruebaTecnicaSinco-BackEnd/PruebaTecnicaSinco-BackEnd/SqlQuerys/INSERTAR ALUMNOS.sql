CREATE OR ALTER PROCEDURE [Stored_Procedures].[InsertAlumnos]
(
	@Identificacion NVARCHAR(450),
	@Nombre         NVARCHAR(MAX), 
	@Apellido       NVARCHAR(MAX),
	@Edad		    NVARCHAR(MAX),
	@Direccion	    NVARCHAR(MAX),
	@Telefono	    NVARCHAR(MAX),
	@AnoAcademico   NVARCHAR(MAX),
	@CodeAsignatura NVARCHAR(MAX)
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