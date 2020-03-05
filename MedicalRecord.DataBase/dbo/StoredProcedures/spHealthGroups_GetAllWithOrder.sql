CREATE PROCEDURE [dbo].[spHealthGroups_GetAllWithOrder]
	@key varchar(20)
AS
BEGIN
	IF @key = 'Title'
		BEGIN
			SELECT
				[Id],
				[Title],
				[Description]
			FROM [dbo].[HealthGroups]
			WHERE [IsDeleted] = 0
			ORDER By [Title]
		END
	ELSE
		BEGIN
			SELECT
				[Id],
				[Title],
				[Description]
			FROM [dbo].[HealthGroups]
			WHERE [IsDeleted] = 0
			ORDER By [Description]
		END
END
