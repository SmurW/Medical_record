CREATE PROCEDURE [dbo].[spDiagnoses_GetLike]
	@value nvarchar(50)
AS
BEGIN
	SELECT
		[Id],
		[Name],
		[Description]
	FROM [dbo].[Diagnoses]
	WHERE [Name] LIKE CONCAT(@value, '%') AND [IsDeleted] = 0;
END