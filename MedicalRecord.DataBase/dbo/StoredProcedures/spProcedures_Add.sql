CREATE PROCEDURE [dbo].[spProcedures_Add]
	@name nvarchar(50),
	@desc nvarchar(500)
AS
BEGIN

	INSERT INTO dbo.Procedures
		(Name, Description)
	VALUES
		(@name, @desc);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END
