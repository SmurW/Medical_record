CREATE PROCEDURE [dbo].[spHealthGroups_GetLike]
	@value nvarchar(50)
AS
BEGIN
	SELECT
		[Id],
		[Title],
		[Description]
	FROM [dbo].[HealthGroups]
	WHERE [Title] LIKE CONCAT(@value, '%') AND [IsDeleted] = 0;
END