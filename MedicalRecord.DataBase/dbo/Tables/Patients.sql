CREATE TABLE [dbo].[Patients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CardNumber] NVARCHAR(100) NOT NULL UNIQUE, 
    [FirstName] NVARCHAR(50) NOT NULL , 
    [LastName] NVARCHAR(50) NOT NULL , 
    [MiddleName] NVARCHAR(50) NOT NULL , 
    [Sex] NVARCHAR(50) NOT NULL, 
    [Birthdate] DATETIME NOT NULL DEFAULT GETDATE(), 
    [RegistrationDate] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Residence] NVARCHAR(100) NOT NULL, 
    [PassportNumber] NVARCHAR(50) NOT NULL UNIQUE, 
    [PassportSeries] NVARCHAR(50) NOT NULL, 
    [PassportUFMS] NVARCHAR(50) NOT NULL, 
    [PassportIssueDate] DATETIME NOT NULL DEFAULT GETDATE(), 
    [PassportDepCode] NVARCHAR(50) NOT NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0
)
