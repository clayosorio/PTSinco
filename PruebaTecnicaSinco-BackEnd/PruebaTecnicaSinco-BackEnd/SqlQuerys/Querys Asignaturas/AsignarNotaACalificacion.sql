CREATE OR ALTER PROCEDURE [Stored_Procedures].[AsignarNotaACalificacion]
(
	@IdentificacionProfesor VARCHAR(450),
	@IdentificacionAlumno VARCHAR(450),
	@CalificacionFinal VARCHAR(450)
)
AS
BEGIN 
	SET NOCOUNT ON
		
		IF EXISTS
		(
			SELECT TOP 1
					IdCalificaciones
			FROM 
					Calificaciones
			WHERE
					IdentificacionAlumno = @IdentificacionAlumno AND IdentificacionProfesor = @IdentificacionProfesor
		)

		BEGIN TRY
			BEGIN TRANSACTION
				BEGIN 
					UPDATE 
						Calificaciones
					SET
						CalificacionFinal = @CalificacionFinal
					WHERE
						IdentificacionAlumno = @IdentificacionAlumno AND IdentificacionProfesor = @IdentificacionProfesor
						COMMIT;
				END
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
				ROLLBACK;
				THROW 55000,'***(Ups!!)***Ha ocurrido un error!!', 1;
		END CATCH
END



