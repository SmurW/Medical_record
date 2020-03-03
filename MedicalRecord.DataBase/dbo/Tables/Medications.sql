CREATE TABLE [dbo].[Medications]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL UNIQUE, 
    [Description] NVARCHAR(500) NULL, 
    [QuantityPackage] INT NOT NULL DEFAULT 0, 
    [RestPackages] INT NOT NULL DEFAULT 0, 
    [ArrivalPackages] INT NOT NULL DEFAULT 0, 
    [RemainedUnits] INT NOT NULL DEFAULT 0, 
    [ArrivalDate] DATETIME NULL, 
    [ShelfLife] DATETIME NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0
)
