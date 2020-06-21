CREATE PROCEDURE [dbo].[spUsers_Update]
	@id int = 0,
	@log nvarchar(50),
	@pass nvarchar(50)
AS
BEGIN

	UPDATE dbo.Users
	SET [Login] = @log,
		[Password] = @pass
	WHERE [Id] = @id;

END