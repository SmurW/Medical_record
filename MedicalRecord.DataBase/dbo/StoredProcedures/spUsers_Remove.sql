CREATE PROCEDURE [dbo].[spUsers_Remove]
	@id int = 0
AS
BEGIN
	--soft удаление
	UPDATE dbo.Users
	SET [IsDeleted] = 1
	WHERE [Id] = @id;

END
