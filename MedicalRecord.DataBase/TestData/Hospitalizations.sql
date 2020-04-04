--ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Госпитализация
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Hospitalizations] ON;
GO

INSERT INTO dbo.Hospitalizations
	(Id, PatientId, StartHospitalizationDate, EndHospitalizationDate, MedicalOrganization, DefinitiveDiagnosis, IsDeleted)
VALUES
	(1, 1, '20200507', '20200807', N'Городская больница №2', N'Окноч. диагноз 2', 0),
	(2, 1, '20191224', '20200325', N'Удаленный', N'Пример удаленной госпитализации', 1),
	(3, 2, '20180113', '20180514', N'Городская больница №2', N'Окноч. диагноз 1', 0),
	(4, 2, '20191030', '20200229', N'Городская больница №2', N'Окноч. диагноз 2', 0),
	(5, 2, '20170313', '20170510', N'Городская больница №2', N'Пневмония', 0),
	(6, 3, '20190730', '20190820', N'Городская больница №2', N'Острое пищевое отравление', 0);
GO

SET IDENTITY_INSERT [dbo].[Hospitalizations] OFF;
GO