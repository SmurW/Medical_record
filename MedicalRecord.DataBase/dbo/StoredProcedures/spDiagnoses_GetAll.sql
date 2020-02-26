CREATE PROCEDURE [dbo].[spDiagnoses_GetAll]
	
AS
BEGIN
	
	SELECT
		[Id],
		[Name],
		[Description],
		[IsDeleted]
	FROM [dbo].[Diagnoses];

END
