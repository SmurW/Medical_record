CREATE TABLE [dbo].[Medications]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL UNIQUE, 
    [Description] NVARCHAR(500) NULL, 
    [QuantityPackage] INT NULL, 
    [RestPackages] INT NULL, 
    [ArrivalPackages] NVARCHAR(50) NULL, 
    [RemainedUnits] NVARCHAR(50) NULL, 
    [ArrivalDate] DATETIME NULL, 
    [ShelfLife] DATETIME NULL, 
    [IsDeleted] BIT NOT NULL DEFAULT 0
)
