CREATE PROCEDURE [dbo].[spHealthGroups_GetAll]
	
AS
BEGIN
	
	SELECT
		[Id],
		[Title],
		[Description]
	FROM [dbo].[HealthGroups]
	WHERE [IsDeleted] = 0; --исключаем из выборки удаленные группы здаровья
END