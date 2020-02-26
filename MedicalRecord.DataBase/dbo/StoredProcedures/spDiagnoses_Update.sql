CREATE PROCEDURE [dbo].[spDiagnoses_Update]
	@id int = 0,
	@name nvarchar(50),
	@desc nvarchar(500)
AS
BEGIN

	UPDATE dbo.Diagnoses
	SET [Name] = @name,
		[Description] = @desc
	WHERE [Id] = @id;

END
