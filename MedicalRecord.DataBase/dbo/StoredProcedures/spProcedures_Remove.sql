CREATE PROCEDURE [dbo].[spProcedures_Remove]
	@id int = 0
AS
BEGIN
	--soft удаление
	UPDATE dbo.Procedures
	SET [IsDeleted] = 1
	WHERE [Id] = @id;

END
