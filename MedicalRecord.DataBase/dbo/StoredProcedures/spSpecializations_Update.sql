CREATE PROCEDURE [dbo].[spSpecializations_Update]
	@id int = 0,
	@name nvarchar(50)
AS
BEGIN

	UPDATE dbo.Specializations
	SET [Name] = @name
	WHERE [Id] = @id;

END
