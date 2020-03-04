CREATE PROCEDURE [dbo].[spMedications_Add]
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

	INSERT INTO dbo.Medications
		(Name, Description, QuantityPackage, RestPackages,
		ArrivalPackages, RemainedUnits, ArrivalDate, ShelfLife)
	VALUES
		(@name, @desc, @qp, @rp, @ap, @ru, @ad, @sl);

	SELECT SCOPE_IDENTITY(); --возвращает Id только что вставленного
END
