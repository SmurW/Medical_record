CREATE PROCEDURE [dbo].[spPatients_GetAll]
AS
BEGIN
	SELECT 
		[Id],
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
		[PassportIssueDate]

	from [dbo].[Patients]
	WHERE [IsDeleted] = 0;
END
