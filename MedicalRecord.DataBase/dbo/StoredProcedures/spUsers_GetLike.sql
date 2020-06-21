CREATE PROCEDURE [dbo].[spUsers_GetLike]
	@value nvarchar(50)
AS
BEGIN
	SELECT
		[Id],
		[Login],
		[Password],
		[IsDeleted]
	from [dbo].[Users]
	WHERE [Login] LIKE CONCAT(@value, '%') AND [IsDeleted] = 0;
END