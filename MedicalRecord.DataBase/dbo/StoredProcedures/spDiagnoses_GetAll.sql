CREATE PROCEDURE [dbo].[spDiagnoses_GetAll]
	
AS
BEGIN
	
	SELECT
		[Id],
		[Name],
		[Description]
	FROM [dbo].[Diagnoses]
	WHERE [IsDeleted] = 0; --исключаем из выборки удаленные диагнозы

END
