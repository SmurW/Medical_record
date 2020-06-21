CREATE PROCEDURE [dbo].[spProcedures_GetLike]
	@value nvarchar(50)
AS
BEGIN
	SELECT
		[Id],
		[Name],
		[Description]
	from [dbo].[Procedures]
	WHERE [Name] LIKE CONCAT(@value, '%') AND [IsDeleted] = 0;
END