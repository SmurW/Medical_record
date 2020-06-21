CREATE PROCEDURE [dbo].[spProcedures_GetAll]
	
AS
BEGIN
	
	SELECT
		[Id],
		[Name],
		[Description]
	from [dbo].[Procedures]
	WHERE [IsDeleted] = 0; --исключаем из выборки удаленные диагнозы

END
