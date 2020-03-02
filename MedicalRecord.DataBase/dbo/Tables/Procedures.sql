CREATE TABLE [dbo].[Procedures]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0
)
