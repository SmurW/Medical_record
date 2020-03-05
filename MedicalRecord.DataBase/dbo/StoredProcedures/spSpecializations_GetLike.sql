CREATE PROCEDURE [dbo].[spSpecializations_GetLike]
	@value nvarchar(50)
AS
BEGIN
	SELECT
		[Id],
		[Name]
	FROM [dbo].[Specializations]
	WHERE [Name] LIKE CONCAT(@value, '%') AND [IsDeleted] = 0;
END