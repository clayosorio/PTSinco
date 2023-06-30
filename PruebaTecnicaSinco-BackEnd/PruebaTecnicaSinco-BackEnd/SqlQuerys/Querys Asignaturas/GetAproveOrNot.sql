ALTER FUNCTION GetAproveOrNot(@Nota DECIMAL)
RETURNS NVARCHAR(2) 
AS 
BEGIN 
	
	DECLARE @Aprove NVARCHAR(2)

	IF @Nota <= 3
		BEGIN 
			SET @Aprove = 'NO';
			RETURN @Aprove;
		END
	ELSE
		BEGIN 
			SET @Aprove = 'SI';
			RETURN @Aprove;
		END
	RETURN NULL;
END