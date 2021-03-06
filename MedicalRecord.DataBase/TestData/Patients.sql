﻿-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Пациенты
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Patients] ON;
GO

INSERT INTO dbo.Patients
	(Id, CardNumber, LastName, FirstName, MiddleName, Sex, Birthdate, RegistrationDate, Residence, PassportNumber, PassportSeries,
	 PassportUFMS, PassportIssueDate, PassportDepCode, IsDeleted)
VALUES
	(1, N'2345', N'Мухина', N'Ирина', N'Анатольевна',
	    N'Женский', '19840323', '20050513', N'ул. Сборная, дом 29б, кв.23', N'832986', N'44-17'
		, N'ТП №13 отдела УФМС России', '19951111', N'880-013', 0),
	(2, N'Удаленный', N'Пример удаленного пациента', N'Пример удаленного пациента', N'Пример удаленного пациента',
	    N'Удаленный', '19840323', '20050513', N'Удаленный', N'Удаленный', N'Удаленный', N'Удаленный'
		, '19951111', N'Удаленный', 1),
	(3, N'2376', N'Петров', N'Кирилл', N'Геннадьевич',
	    N'Мужской', '19820801', '20010610', N'ул. Морская, дом 15, корп. 2, кв. 23', N'324655', N'39-13'
		, N'ТП №24 отдела УФМС России', '19931211', N'280-002', 0),
	(4, N'3456', N'Кузнецов', N'Станислав', N'Иванович',
	    N'Мужской', '19891013', '20020503', N'ул. Соборная, дом 29б, кв.23', N'832986', N'44-17',
		N'ТП №13 отдела УФМС России', '19951211', N'880-013', 0);
GO

SET IDENTITY_INSERT [dbo].[Patients] OFF;
GO