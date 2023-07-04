
CREATE OR ALTER PROCEDURE [Stored_Procedures].[InsertAsignaturas]
(
	@Codigo VARCHAR(450),
	@Nombre VARCHAR(MAX)
)
AS
BEGIN 
	SET NOCOUNT ON 

		IF EXISTS (SELECT TOP 1 CodigoAsignatura FROM Asignaturas WHERE CodigoAsignatura = @Codigo AND Nombre = @Nombre)
			BEGIN 
				THROW 52000, 'La asignatura que intenta registrar ya se encuentra creada', 1;
			END

		BEGIN
			INSERT INTO 
						Asignaturas
			VALUES
			(
				@Codigo,
				@Nombre,
				NULL
			)
		END
END
