CREATE PROCEDURE [dbo].[spSpecializations_Add]
	@name nvarchar(50)
AS
BEGIN

	INSERT INTO dbo.Specializations
		(Name)
	VALUES
		(@name);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END
