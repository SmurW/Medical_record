CREATE PROCEDURE [dbo].[spDiagnoses_Remove]
	@id int = 0
AS
BEGIN
	--soft удаление
	UPDATE dbo.Diagnoses
	SET [IsDeleted] = 1
	WHERE [Id] = @id;

END
