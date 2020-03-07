CREATE PROCEDURE [dbo].[spHealthGroups_GetById]
	@id int = 0
AS
BEGIN
	
	SELECT
		[Id],
		[Title]
	FROM [dbo].[HealthGroups]
	WHERE [Id] = @id;

END