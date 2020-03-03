CREATE PROCEDURE [dbo].[spMedications_GetAllWithOrder]
	@key varchar(20)
AS
BEGIN
	IF @key = 'Name'
		BEGIN
			SELECT
				[Id],
				[Name],
				[Description],
				[QuantityPackage],
				[RestPackages],
				[ArrivalPackages],
				[RemainedUnits],
				[ArrivalDate],
				[ShelfLife],
				[IsDeleted]
			FROM [dbo].[Medications]
			WHERE [IsDeleted] = 0
			ORDER By [Name]
		END
	ELSE
		BEGIN
			SELECT
				[Id],
				[Name],
				[Description],
				[QuantityPackage],
				[RestPackages],
				[ArrivalPackages],
				[RemainedUnits],
				[ArrivalDate],
				[ShelfLife],
				[IsDeleted]
			FROM [dbo].[Medications]
			WHERE [IsDeleted] = 0
			ORDER By [Description]
		END
END
