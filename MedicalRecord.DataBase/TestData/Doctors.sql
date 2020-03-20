-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Доктора
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Doctors] ON;
GO

INSERT INTO [dbo].[Doctors]
	(Id, LastName, FirstName, MiddleName, SpecializationId, IsDeleted)
VALUES
	(1, N'Иванова', N'Галина', N'Петровна', 3, 0),
	(2, N'Васницова', N'Марина', N'Витальевна', 1, 0),
	(3, N'Кулагина', N'Виктория', N'Геннадьевна', 3, 0),
	(4, N'Молодцова', N'Ирина', N'Максимовна', 4, 0),
	(5, N'Круглов', N'Дмитрий', N'Сергеевич', 1, 0);
GO

SET IDENTITY_INSERT [dbo].[Doctors] OFF;
GO