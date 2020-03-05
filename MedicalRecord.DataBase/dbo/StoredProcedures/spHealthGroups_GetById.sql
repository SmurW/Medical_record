﻿CREATE PROCEDURE [dbo].[spHealthGroups_GetById]
	@id int = 0
AS
BEGIN
	
	SELECT
		[Id],
		[Title],
		[Description]
	FROM [dbo].[HealthGroups]
	WHERE [Id] = @id;

END