CREATE OR ALTER PROCEDURE [Stored_Procedures].[GetAsignaturas]
AS 
BEGIN 
	SET NOCOUNT ON
		BEGIN 
			SELECT 
				CodigoAsignatura,
				Nombre
			FROM 
				Asignaturas
		END
END