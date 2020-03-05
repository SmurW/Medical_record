CREATE PROCEDURE [dbo].[spSpecializations_GetById]
	@id int = 0
AS
BEGIN
	
	SELECT
		[Id],
		[Name]
	FROM [dbo].[Specializations]
	WHERE [Id] = @id;

END