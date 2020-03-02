CREATE PROCEDURE [dbo].[spProcedures_GetAllWithOrder]
	@key varchar(20)
AS
BEGIN
	IF @key = 'Name'
		BEGIN
			SELECT
				[Id],
				[Name],
				[Description]
			FROM [dbo].[Procedures]
			WHERE [IsDeleted] = 0
			ORDER By [Name]
		END
	ELSE
		BEGIN
			SELECT
				[Id],
				[Name],
				[Description]
			FROM [dbo].[Procedures]
			WHERE [IsDeleted] = 0
			ORDER By [Description]
		END
END
