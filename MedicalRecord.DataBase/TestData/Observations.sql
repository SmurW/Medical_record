﻿-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Наблюдений
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Observations] ON;
GO

INSERT INTO [dbo].[Observations]
	(Id, PatientId, DiagnosisId, DoctorId, StartObservationDate, EndObservationDate)
VALUES
	(1, 1, 1, 1, '20050723', '20050730'),
	(2, 1, 1, 1, '20070813', '20070912'),
	(3, 3, 1, 2, '20070903', '20070912'),
	(4, 4, 3, 3, '20080513', '20080524'),
	(5, 1, 3, 2, '20080523', '20080529'),
	(6, 4, 4, 4, '20080213', '20080220'),
	(7, 3, 4, 5, '20090123', '20090125'),
	(8, 4, 1, 4, '20090201', '20090214'),
	(9, 4, 1, 1, '20090623', '20090710'),
	(10, 3, 3, 3, '20090723', '20090730'),
	(11, 3, 3, 1, '20090803', '20090907'),
	(12, 4, 4, 4, '20100313', '20100330'),
	(13, 1, 4, 5, '20110323', '20110404'),
	(14, 1, 4, 4, '20120914', '20121005');
GO

SET IDENTITY_INSERT [dbo].[Observations] OFF;
GO