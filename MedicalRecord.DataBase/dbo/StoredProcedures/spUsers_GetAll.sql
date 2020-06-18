CREATE PROCEDURE [dbo].[spUsers_GetAll]
AS
BEGIN
	SELECT
		[Id],
		[Login],
		[Password]

	from [dbo].[Users]
	WHERE [IsDeleted] = 0; --исключаем из выборки удаленных пользователей
END
