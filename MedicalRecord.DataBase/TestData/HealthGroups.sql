-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Группа здаровья
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[HealthGroups] ON;
GO

INSERT INTO [dbo].[HealthGroups]
	(Id, Title, Description, IsDeleted)
VALUES
	(1, N'Первая группа', N'', 0),
	(2, N'Удаленный', N'', 1),
	(3, N'Вторая группа', N'', 0),
	(4, N'Третья группа', N'', 0),
	(5, N'Четвертая группа', N'', 0)
GO

SET IDENTITY_INSERT [dbo].[HealthGroups] OFF;
GO