CREATE PROCEDURE [dbo].[spProcedures_GetAll]
	
AS
BEGIN
	
	SELECT
		[Id],
		[Name],
		[Description]
	FROM [dbo].[Procedures]
	WHERE [IsDeleted] = 0; --исключаем из выборки удаленные диагнозы

END
