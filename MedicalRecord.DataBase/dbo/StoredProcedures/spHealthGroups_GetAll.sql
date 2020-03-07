CREATE PROCEDURE [dbo].[spHealthGroups_GetAll]
	
AS
BEGIN
	
	SELECT
		[Id],
		[Title]
	FROM [dbo].[HealthGroups]
	WHERE [IsDeleted] = 0; --исключаем из выборки удаленные группы помощи

END
