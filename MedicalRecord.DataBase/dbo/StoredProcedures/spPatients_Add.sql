CREATE PROCEDURE [dbo].[spPatients_Add]
	@cardn nvarchar(50),
	@lname nvarchar(50),
	@fname nvarchar(50),
	@mname nvarchar(50),
	@sex   nvarchar(50),
	@rsdn  nvarchar(50),
	@pasnum nvarchar(50),
	@passrs nvarchar(50),
	@pasufms nvarchar(50),
	@pasdcod nvarchar(50),
	@bdate datetime,
	@rdate datetime,
	@pdate   datetime
AS
BEGIN

	INSERT INTO dbo.Patients
		(CardNumber,LastName,FirstName,MiddleName,Sex,Residence,PassportNumber,PassportSeries,PassportUFMS,PassportDepCode,
		Birthdate,RegistrationDate,PassportIssueDate)
	VALUES
		(@cardn,@lname,@fname,@mname,@sex,@rsdn,@pasnum,@passrs,@pasufms,@pasdcod,@bdate,@rdate,@pdate);	

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END