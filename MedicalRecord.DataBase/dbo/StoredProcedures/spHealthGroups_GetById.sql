CREATE PROCEDURE [dbo].[spHealthGroups_GetById]
	@id int = 0
AS
BEGIN
	
	SELECT
		[Id],
		[Title]
	from [dbo].[HealthGroups]
	WHERE [Id] = @id;

END