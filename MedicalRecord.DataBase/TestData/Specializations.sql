-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Специализация
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Specializations] ON;
GO

INSERT INTO [dbo].[Specializations]
	(Id, Name, IsDeleted)
VALUES
	(1, N'ЛОР', 0),
	(2, N'Удаленный', 1),
	(3, N'Терапевт', 0),
	(4, N'Хирург', 0);
GO

SET IDENTITY_INSERT [dbo].[Specializations] OFF;
GO