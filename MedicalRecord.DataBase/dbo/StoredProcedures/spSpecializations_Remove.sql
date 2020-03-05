CREATE PROCEDURE [dbo].[spSpecializations_Remove]
	@id int = 0
AS
BEGIN
	--soft удаление
	UPDATE dbo.Specializations
	SET [IsDeleted] = 1
	WHERE [Id] = @id;

END
