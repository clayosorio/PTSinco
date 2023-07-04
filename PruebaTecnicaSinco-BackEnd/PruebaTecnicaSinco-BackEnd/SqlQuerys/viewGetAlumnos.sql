CREATE OR ALTER   VIEW [dbo].[GetAlumnos]
AS
SELECT 
	IdentificacionAlumno ,
	Nombre, 
	Edad, 
	Telefono

FROM 
	Alumnos
GO


