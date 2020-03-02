CREATE PROCEDURE [dbo].[spProcedures_GetLike]
	@value nvarchar(50)
AS
BEGIN
	SELECT
		[Id],
		[Name],
		[Description]
	FROM [dbo].[Procedures]
	WHERE [Name] LIKE CONCAT(@value, '%') AND [IsDeleted] = 0;
END