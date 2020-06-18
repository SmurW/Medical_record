CREATE PROCEDURE [dbo].[spHealthGroups_GetAll]
	
AS
BEGIN
	
	SELECT
		[Id],
		[Title]
	from [dbo].[HealthGroups]
	WHERE [IsDeleted] = 0; --исключаем из выборки удаленные группы помощи

END
