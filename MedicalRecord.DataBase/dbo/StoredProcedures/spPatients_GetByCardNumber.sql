CREATE PROCEDURE [dbo].[spPatients_GetByCardNumber]
	@cardn nvarchar(50)
AS
BEGIN
	SELECT [Id],
		[CardNumber],
		[LastName],
		[FirstName],
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
	WHERE h.CardNumber = @cardn AND h.IsDeleted = 0;

END
