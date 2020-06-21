CREATE PROCEDURE [dbo].[spProcedures_GetById]
	@id int = 0
AS
BEGIN
	
	SELECT
		[Id],
		[Name],
		[Description]
	from [dbo].[Procedures]
	WHERE [Id] = @id;

END