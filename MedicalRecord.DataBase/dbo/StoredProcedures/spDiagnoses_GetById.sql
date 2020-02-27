CREATE PROCEDURE [dbo].[spDiagnoses_GetById]
	@id int = 0
AS
BEGIN
	
	SELECT
		[Id],
		[Name],
		[Description]
	FROM [dbo].[Diagnoses]
	WHERE [Id] = @id;

END