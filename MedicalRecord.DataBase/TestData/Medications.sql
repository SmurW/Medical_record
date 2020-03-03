-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Лекарства
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Medications] ON;
GO

INSERT INTO [dbo].[Medications]
	(Id, Name, Description, QuantityPackage, RestPackages, ArrivalPackages, RemainedUnits, ArrivalDate, ShelfLife, IsDeleted)
VALUES
	(1, N'', N'', 30, 16, 48,  0),
	(2, N'Удаленный', N'Пример удаленного лекарства', 1),
	(3, N'', N'', 0),
	(4, N'', N'', 0);
GO

SET IDENTITY_INSERT [dbo].[Medications] OFF;
GO