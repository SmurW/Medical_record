CREATE PROCEDURE [dbo].[spProcedures_Update]
	@id int = 0,
	@name nvarchar(50),
	@desc nvarchar(500)
AS
BEGIN

	UPDATE dbo.Procedures
	SET [Name] = @name,
		[Description] = @desc
	WHERE [Id] = @id;

END
