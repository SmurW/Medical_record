CREATE PROCEDURE [dbo].[spDiagnoses_GetAllWithOrder]
	@key varchar(20)
AS
BEGIN
	IF @key = 'Name'
		BEGIN
			SELECT
				[Id],
				[Name],
				[Description]
			from [dbo].[Diagnoses]
			WHERE [IsDeleted] = 0
			ORDER By [Name]
		END
	ELSE
		BEGIN
			SELECT
				[Id],
				[Name],
				[Description]
			from [dbo].[Diagnoses]
			WHERE [IsDeleted] = 0
			ORDER By [Description]
		END
END
