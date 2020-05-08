CREATE PROCEDURE [dbo].[spPatients_Remove]
	@id int = 0
AS
BEGIN
	--soft удаление
	UPDATE dbo.Patients
	SET [IsDeleted] = 1
	WHERE [Id] = @id;

END