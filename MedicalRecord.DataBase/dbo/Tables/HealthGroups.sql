CREATE TABLE [dbo].[HealthGroups]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0
)
