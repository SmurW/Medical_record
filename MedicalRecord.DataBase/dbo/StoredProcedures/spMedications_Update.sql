CREATE PROCEDURE [dbo].[spMedications_Update]
	@id int = 0,
	@name nvarchar(50),
	@desc nvarchar(500),
	@qp int,
	@rp int,
	@ap int,
	@ru int,
	@ad datetime,
	@sl datetime
AS
BEGIN

	UPDATE dbo.Medications
	SET [Name] = @name,
		[Description] = @desc,
		[QuantityPackage] = @qp,
		[RestPackages] = @rp,
		[ArrivalPackages] = @ap,
		[RemainedUnits] = @ru,
		[ArrivalDate] = @ad,
		[ShelfLife] = @sl
	WHERE [Id] = @id;

END
