CREATE PROCEDURE [dbo].[spHealthGroups_Update]
	@id int = 0,
	@title nvarchar(50),
	@desc nvarchar(500)
AS
BEGIN

	UPDATE dbo.HealthGroups
	SET [Title] = @title
	WHERE [Id] = @id;

END
