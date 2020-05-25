CREATE PROCEDURE [dbo].[spPatients_Add]
	@cardn nvarchar(50),
	@lname nvarchar(50),
	@fname nvarchar(50),
	@mname nvarchar(50),
	@sex   nvarchar(50),
	@bdate date,
	@regdate date,
	@residn  nvarchar(50),
	@pasnum nvarchar(50),
	@passer nvarchar(50),
	@pasufms nvarchar(50),
	@pasissue date,
	@pasdepcod nvarchar(50)
AS
BEGIN

	INSERT INTO dbo.Patients
		(CardNumber, LastName, FirstName, MiddleName, Sex, Birthdate, RegistrationDate, Residence,
		PassportNumber, PassportSeries, PassportUFMS, PassportIssueDate, PassportDepCode)
	VALUES
		(@cardn, @lname, @fname, @mname, @sex, @bdate, @regdate, @residn,
		@pasnum, @passer, @pasufms, @pasissue, @pasdepcod);	

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END