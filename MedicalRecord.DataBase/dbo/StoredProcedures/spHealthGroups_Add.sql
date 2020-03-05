CREATE PROCEDURE [dbo].[spHealthGroups_Add]
	@title nvarchar(50),
	@desc nvarchar(500)
AS
BEGIN

	INSERT INTO dbo.HealthGroups
		(Title,Description)
	VALUES
		(@title, @desc);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END
