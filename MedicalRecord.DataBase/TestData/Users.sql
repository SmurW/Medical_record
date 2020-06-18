-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Users
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Users] ON;
GO

INSERT INTO [dbo].[Users]
	(Id, Login, Password, IsDeleted)
VALUES
	(1, N'Admin', N'123456', 0),
	(2, N'Удаленный', N'Удаленный', 1),
	(3, N'User', N'12345', 0),
	(4, N'User', N'1234', 0);
GO

SET IDENTITY_INSERT [dbo].[Users] OFF;
GO