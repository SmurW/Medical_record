CREATE PROCEDURE [dbo].[spUsers_Add]
	@log nvarchar(50),
	@pass nvarchar(50)
AS
BEGIN

	INSERT INTO [dbo].[Users]
		(Login, Password)
	VALUES
		(@log, @pass);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END