-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Группа здаровья
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[HealthGroups] ON;
GO

INSERT INTO [dbo].[HealthGroups]
	(Id, Title, IsDeleted)
VALUES
	(1, N'Первая группа', 0),
	(2, N'Удаленный', 1),
	(3, N'Вторая группа', 0),
	(4, N'Третья группа', 0);
GO

SET IDENTITY_INSERT [dbo].[HealthGroups] OFF;
GO