CREATE PROCEDURE [dbo].[spHealthGroups_Add]
	@title nvarchar(50)
AS
BEGIN

	INSERT INTO dbo.HealthGroups
		(Title)
	VALUES
		(@title);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END
