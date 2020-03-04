CREATE PROCEDURE [dbo].[spMedications_Remove]
	@id int = 0
AS
BEGIN
	--soft удаление
	UPDATE dbo.Medications
	SET [IsDeleted] = 1
	WHERE [Id] = @id;

END
