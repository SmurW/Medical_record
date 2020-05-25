CREATE PROCEDURE [dbo].[spPatients_Update]
	@id int = 0,
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

	UPDATE dbo.Patients
	SET [CardNumber] = @cardn,
		[LastName] = @lname,
		[FirstName] = @fname,
		[MiddleName] = @mname,
		[Sex] = @sex,
		[Birthdate] = @bdate,
		[RegistrationDate] = @regdate,
		[Residence] = @residn,
		[PassportNumber] = @pasnum,
		[PassportSeries] = @passer,
		[PassportUFMS] = @pasufms,
		[PassportIssueDate] = @pasissue,
		[PassportDepCode] = @pasdepcod
		
	WHERE [Id] = @id;
END
