CREATE PROCEDURE [dbo].[spMedications_GetLike]
	@value nvarchar(50)
AS
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
	from [dbo].[Medications]
	WHERE [Name] LIKE CONCAT(@value, '%') AND [IsDeleted] = 0;
END
