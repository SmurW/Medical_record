CREATE PROCEDURE [dbo].[spPatients_GetAll]
AS
	SELECT 
		[Id],
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
	FROM dbo.Patients
	WHERE [IsDeleted] = 0;
RETURN 0
