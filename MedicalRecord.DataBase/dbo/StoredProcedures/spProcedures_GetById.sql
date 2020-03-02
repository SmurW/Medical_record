CREATE PROCEDURE [dbo].[spProcedures_GetById]
	@id int = 0
AS
BEGIN
	
	SELECT
		[Id],
		[Name],
		[Description]
	FROM [dbo].[Procedures]
	WHERE [Id] = @id;

END