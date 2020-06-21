CREATE PROCEDURE [dbo].[spSpecializations_GetAll]
	
AS
BEGIN
	
	SELECT
		[Id],
		[Name]
	from [dbo].[Specializations]
	WHERE [IsDeleted] = 0; --исключаем из выборки удаленные специализации

END
