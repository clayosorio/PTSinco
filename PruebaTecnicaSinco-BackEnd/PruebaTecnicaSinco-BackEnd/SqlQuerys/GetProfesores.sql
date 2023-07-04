
CREATE OR ALTER PROCEDURE [Stored_Procedures].[GetProfesores]
AS 
BEGIN 
	SET NOCOUNT ON 
		BEGIN 
		
			SELECT 
				IdentificacionProfesor, 
				Nombre,
				Apellido,
				Edad, 
				Direccion,
				Telefono
			FROM 
				Profesores
		END
END