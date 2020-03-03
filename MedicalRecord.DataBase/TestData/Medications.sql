-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Лекарства
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Medications] ON;
GO

INSERT INTO dbo.Medications
	(Id, Name, Description, QuantityPackage, RestPackages, ArrivalPackages, RemainedUnits, ArrivalDate, ShelfLife, IsDeleted)
VALUES
	(1, N'Пирацетам', N'Ноотропное средство. Оказывает положительное влияние на обменные процессы и кровообращение мозга.',
	    30, 16, 48, 3, '19930320', '19951001', 0),
	(2, N'Удаленный', N'Пример удаленного лекарства',
	    10, 10, 100, 1, '19900101', '19950101', 1),
	(3, N'Глюкофаж', N'Таблетки белые, круглые, двояковыпуклые, покрытые пленочной оболочкой.',
	    20, 32, 245, 13, '19900320', '19961101', 0),
	(4, N'Арбидол', N'Капсулы твердые желатиновые, размер №0, белого цвета.',
	    15, 48, 300, 7, '19920507', '19940201', 0);
GO

SET IDENTITY_INSERT [dbo].[Medications] OFF;
GO