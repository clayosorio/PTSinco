CREATE OR ALTER PROCEDURE [Stored_Procedures].[GetAlumnos]
AS 
BEGIN 
	SET NOCOUNT ON 
	BEGIN 
		SELECT 
			IdentificacionAlumno, 
			Nombre,
			Apellido,
			Edad, 
			Direccion,
			Telefono
			
		FROM
			Alumnos
	END
END