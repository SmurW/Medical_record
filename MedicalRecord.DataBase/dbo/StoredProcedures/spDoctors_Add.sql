CREATE PROCEDURE [dbo].[spDoctors_Add]
	@lName nvarchar(100),
	@fName nvarchar(50),
	@mName nvarchar(100),
	@specId int
AS
BEGIN

	INSERT INTO [dbo].[Doctors]
		(LastName, FirstName, MiddleName, SpecializationId)
	VALUES
		(@lName, @fName, @mName, @specId);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END
