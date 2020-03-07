CREATE PROCEDURE [dbo].[spHealthGroups_GetAllWithOrder]
	@key varchar(20)
AS
BEGIN
	IF @key = 'Title'
		BEGIN
			SELECT
				[Id],
				[Title]
			FROM [dbo].[HealthGroups]
			WHERE [IsDeleted] = 0
			ORDER By [Title]
		END
END
