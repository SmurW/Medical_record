CREATE PROCEDURE [dbo].[spSpecializations_GetAllWithOrder]
	@key varchar(20)
AS
BEGIN
	IF @key = 'Name'
		BEGIN
			SELECT
				[Id],
				[Name]
			FROM [dbo].[Specializations]
			WHERE [IsDeleted] = 0
			ORDER By [Name]
		END
END
