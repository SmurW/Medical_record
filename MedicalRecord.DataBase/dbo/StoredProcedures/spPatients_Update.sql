CREATE PROCEDURE [dbo].[spPatients_Update]
	@id int = 0,
	@cardn nvarchar(50),
	@fname nvarchar(50),
	@lname nvarchar(50),
	@mname nvarchar(50),
	@sex   nvarchar(50),
	@rsdn  nvarchar(50),
	@pasnum nvarchar(50),
	@passrs nvarchar(50),
	@pasufms nvarchar(50),
	@pasdcod nvarchar(50),
	@bdate datetime,
	@rdate datetime,
	@pdate datetime
AS
BEGIN

	UPDATE dbo.Patients
	SET [CardNumber] = @cardn,
		[FirstName] = @fname,
		[LastName] = @lname,
		[MiddleName] = @mname,
		[Sex] = @sex,
		[Residence] = @rsdn,
		[PassportNumber] = @pasnum,
		[PassportSeries] = @passrs,
		[PassportUFMS] = @pasufms,
		[PassportDepCode] = @pasdcod,
		[Birthdate] = @bdate,
		[RegistrationDate] = @rdate,
		[PassportIssueDate] = @pdate
		
	WHERE [Id] = @id;
END
