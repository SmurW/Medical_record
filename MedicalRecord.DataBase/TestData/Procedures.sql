-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Процедуры
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Procedures] ON;
GO

INSERT INTO [dbo].[Procedures]
	(Id, Name, Description, IsDeleted)
VALUES
	(1, N'Процедура 1', N'Описание процедуры', 0),
	(2, N'Удаленный', N'Пример удаленной процедуры', 1),
	(3, N'Процедруа 2', N'Описание процедуры', 0),
	(4, N'Процедруа 3', N'Описание процедуры', 0);
GO

SET IDENTITY_INSERT [dbo].[Procedures] OFF;
GO