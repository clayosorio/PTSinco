	CREATE OR ALTER PROCEDURE [Stored_Procedures].[CreacionCalificaciones]
	(
	      @IdCalificaciones UNIQUEIDENTIFIER,
          @AñoAcademico VARCHAR(MAX),
          @IdentificacionAlumno VARCHAR(MAX),
          @NombreAlumno VARCHAR(MAX),
          @CodigoAsignatura VARCHAR(MAX),
	      @NombreAsignatura VARCHAR(MAX),
          @CalificacionFinal FLOAT = 0,
          @Aprobo VARCHAR(MAX) = NULL
	)
	AS 
	BEGIN 
		SET NOCOUNT ON

		Declare @IdentificacionProfesor VARCHAR(450), @NombreProfesor Varchar(450)
		SELECT @IdentificacionProfesor = pro.IdentificacionProfesor, @NombreProfesor = pro.Nombre
		FROM Asignaturas asi
		INNER JOIN Profesores pro ON PRO.IdentificacionProfesor = asi.IdentificacionProfesor
		WHERE asi.CodigoAsignatura = @CodigoAsignatura

			
			IF NOT EXISTS(SELECT TOP 1 IdentificacionAlumno from Alumnos where IdentificacionAlumno = @IdentificacionAlumno)
				BEGIN 
					THROW 53000, 'El Alumno al que intenta estipular la asignatura no se encuentra registrado', 1;
				END

		   IF (@IdentificacionProfesor IS NULL)
				BEGIN 
					THROW 53000, 'La asignatura que intenta otorgar no existe o no está asociada a un profesor', 1;
				END
		
		BEGIN TRY
			BEGIN TRANSACTION
				BEGIN 
				INSERT INTO Calificaciones
				VALUES
				(
				    NEWID(), 
					@AñoAcademico, 
					@IdentificacionAlumno,
					@NombreAlumno, 
					@CodigoAsignatura, 
					@NombreAsignatura, 
					@IdentificacionProfesor, 
					@NombreProfesor, 
					@CalificacionFinal, 
					@Aprobo
				)
				COMMIT;
				END
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
				ROLLBACK;
				THROW 53000, 'Trancsacción fallida, por favor valida con el admin...!!', 1;	
		END CATCH
END