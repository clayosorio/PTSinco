	CREATE OR ALTER PROCEDURE [Stored_Procedures].[CreacionCalificaciones]
	(
          @AnoAcademico VARCHAR(MAX),
          @IdentificacionAlumno VARCHAR(MAX),
          @NombreAlumno VARCHAR(MAX),
          @CodigoAsignatura VARCHAR(MAX),
	      @NombreAsignatura VARCHAR(MAX),
		  @IdentificacionProfesor VARCHAR(450),
		  @NombreProfesor VARCHAR(MAX),
          @CalificacionFinal DECIMAL,
          @Aprobo VARCHAR(MAX) = NULL
	)
	AS 
	BEGIN 
		SET NOCOUNT ON
		
			IF NOT EXISTS(SELECT TOP 1 IdentificacionAlumno from Alumnos where IdentificacionAlumno = @IdentificacionAlumno)
				BEGIN 
					THROW 53000, 'El Alumno al que intenta estipular la asignatura no se encuentra registrado', 1;
				END

		   IF NOT EXISTS(SELECT TOP 1 IdentificacionProfesor FROM Asignaturas WHERE IdentificacionProfesor = @IdentificacionProfesor and CodigoAsignatura = @CodigoAsignatura )
				BEGIN 
					THROW 53000, 'La asignatura que intenta otorgar no existe o no está asociada a un profesor', 1;
				END

			IF EXISTS (SELECT TOP 1 IdCalificaciones FROM Calificaciones WHERE IdentificacionAlumno = @IdentificacionAlumno AND AnoAcademico = @AnoAcademico AND CodigoAsignatura = @CodigoAsignatura)
				BEGIN 
					THROW 53000, 'El alumno indicado ya tiene el año y la asignatura indicado asociados ', 1;
				END
		
		BEGIN TRY
			BEGIN TRANSACTION
				BEGIN 
				INSERT INTO Calificaciones
				VALUES
				(
				    NEWID(), 
					@AnoAcademico, 
					@IdentificacionAlumno,
					@NombreAlumno, 
					@CodigoAsignatura, 
					@NombreAsignatura, 
					@IdentificacionProfesor, 
					@NombreProfesor, 
					@CalificacionFinal, 
					dbo.GetAproveOrNot(@CalificacionFinal)
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