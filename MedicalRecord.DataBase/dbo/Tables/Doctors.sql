CREATE TABLE [dbo].[Doctors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[LastName] NVARCHAR(100) NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL,
	[MiddleName] NVARCHAR(100) NOT NULL,
	[SpecializationId] INT,
	[IsDeleted] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Doctors_Specializations] FOREIGN KEY ([SpecializationId]) REFERENCES [Specializations]([Id])
)
