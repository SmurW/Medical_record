CREATE PROCEDURE [dbo].[spPatients_GetByLastName]
	@lname nvarchar(50)
AS
BEGIN
	
	SELECT [Id]
		[CardNumber],
		[FirstName],
		[LastName],
		[MiddleName],
		[Sex],
		[Residence],
		[PassportNumber],
		[PassportSeries],
		[PassportUFMS],
		[PassportDepCode],
		[Birthdate],
		[RegistrationDate],
		[PassportIssueDate],
		[IsDeleted]
	FROM [dbo].[Patients] AS h
	WHERE h.LastName = @lname AND h.IsDeleted = 0;

END
