CREATE OR ALTER PROCEDURE [Stored_Procedures].[UpdateProfesores]
(
	 @Identificacion VARCHAR(450), 
	 @Nombre         VARCHAR(450),       
	 @Apellido       VARCHAR(450),      
	 @Edad           VARCHAR(450),          
	 @Direccion      VARCHAR(450),     
	 @Telefono       VARCHAR(450)    
)	
AS 
BEGIN 

	SET NOCOUNT ON

	IF NOT EXISTS (SELECT TOP 1 IdentificacionProfesor FROM Profesores WHERE IdentificacionProfesor = @Identificacion)
		BEGIN 
			THROW 54000, 'El profesor que intenta actualizar no se encuentra registrdo...', 1;
		END

		BEGIN 
			UPDATE 
				Profesores
			SET 
				Nombre = @Nombre,
				Apellido = @Apellido,
				Edad = @Edad,
				Direccion = @Direccion,
				Telefono = @Telefono
			WHERE 
				IdentificacionProfesor = @Identificacion
		END
END