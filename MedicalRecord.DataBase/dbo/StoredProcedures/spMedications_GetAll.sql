﻿CREATE PROCEDURE [dbo].[spMedications_GetAll]
	
AS
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
	FROM dbo.Medications
	WHERE [IsDeleted] = 0;
RETURN 0
