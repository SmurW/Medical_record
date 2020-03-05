CREATE PROCEDURE [dbo].[spHealthGroups_Remove]
	@id int = 0
AS
BEGIN
	--soft удаление
	UPDATE dbo.HealthGroups
	SET [IsDeleted] = 1
	WHERE [Id] = @id;

END
