-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Осмотров
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Examinations] ON;
GO

INSERT INTO [dbo].[Examinations]
	(Id, ExaminationDate, PatientId, DiagnosisId, HealthGroupId, DoctorId)
VALUES
	(1, '20050120', 1, 3, 1, 2),
	(2, '20050723', 4, 1, 3, 1),
	(3, '20051012', 3, 4, 4, 4),
	(4, '20051020', 4, 1, 3, 5),
	(5, '20060109', 3, 3, 4, 1),
	(6, '20060220', 1, 1, 1, 3),
	(7, '20060310', 3, 4, 4, 1),
	(8, '20060712', 3, 3, 4, 4),
	(9, '20070910', 4, 1, 3, 1),
	(10, '20071220', 1, 4, 1, 2),
	(11, '20080828', 3, 3, 4, 5),
	(12, '20081107', 1, 1, 1, 1),
	(13, '20081215', 4, 3, 3, 3),
	(14, '20090414', 3, 4, 4, 4);
GO

SET IDENTITY_INSERT [dbo].[Examinations] OFF;
GO