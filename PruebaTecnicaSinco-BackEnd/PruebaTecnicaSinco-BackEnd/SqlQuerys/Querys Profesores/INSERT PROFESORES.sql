CREATE OR ALTER PROCEDURE [Stored_Procedures].[InsertProfesores]
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

	IF EXISTS (SELECT TOP 1 IdentificacionProfesor FROM Profesores WHERE IdentificacionProfesor = @Identificacion)
		BEGIN 
			THROW 54000, 'El profesor que intenta registrar ya se encuentra creado, por favor validar la identificación...', 1;
		END

		BEGIN 
			INSERT INTO 
					Profesores
			VALUES
			(
				@Identificacion,
				@Nombre,        
				@Apellido,      
				@Edad,          
				@Direccion,     
				@Telefono      
			)
		END
END