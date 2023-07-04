CREATE OR ALTER PROCEDURE [Stored_Procedures].[AsignarNotaACalificacion]
(
	@IdentificacionProfesor VARCHAR(450),
	@CodigoAsignatura VARCHAR(450)
)
AS
BEGIN 
	SET NOCOUNT ON

	IF NOT EXISTS (SELECT TOP 1 CodigoAsignatura FROM Asignaturas WHERE CodigoAsignatura = @CodigoAsignatura AND IdentificacionProfesor IS NULL)
			BEGIN 
				THROW 55000, 'Después te pongo un mensaje', 1;
			END

	IF NOT EXISTS (SELECT TOP 1 IdentificacionProfesor FROM Profesores WHERE IdentificacionProfesor = @IdentificacionProfesor)
		BEGIN 
			THROW 55000, 'Después te pongo un mensaje', 1;
		END

		BEGIN TRY
			BEGIN TRANSACTION 
				BEGIN 
					UPDATE 
						Asignaturas
					SET 
						IdentificacionProfesor = @IdentificacionProfesor
					WHERE 
						CodigoAsignatura = @CodigoAsignatura
					COMMIT;
				END
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
				ROLLBACK;
			THROW 55000, 'Se achacó esa verga', 1;
		END CATCH
END
