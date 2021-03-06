﻿CREATE PROCEDURE [dbo].[spPatients_GetByLastName]
	@lname nvarchar(50)
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
	from [dbo].[Patients] AS h
	WHERE h.LastName = @lname AND h.IsDeleted = 0;
END
