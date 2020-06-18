CREATE TABLE [dbo].[Patients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[CardNumber] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL,
	[MiddleName] NVARCHAR(50) NOT NULL,
	[Sex] NVARCHAR(50) NOT NULL,
	[Birthdate] DATE NULL,
	[RegistrationDate] DATE NULL,
	[Residence] NVARCHAR(50) NOT NULL,
	[PassportNumber] NVARCHAR(50) NOT NULL,
	[PassportSeries] NVARCHAR(50) NOT NULL,
	[PassportUFMS] NVARCHAR(50) NOT NULL,
	[PassportIssueDate] DATE NULL,
	[PassportDepCode] NVARCHAR(50) NOT NULL,
	[IsDeleted] BIT NOT NULL DEFAULT 0

)