--ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Госпитализация
USE [MedicalRecord]
GO

SET IDENTITY_INSERT [dbo].[Hospitalizations] ON;
GO

INSERT INTO dbo.Hospitalizations
			(Id,PatientId,StartHospitalizationDate, EndHospitalizationDate,MedicalOrganization,DefinitiveDiagnosis, IsDeleted)
	VALUES
			(1, 1, '20200507', '20200807', N'Городская больница №2', N'Окноч. диагноз 2', 0),
			(2, 1, '20191224', '20200325', N'Удаленный', N'Пример удаленной госпитализации', 1),
			(1, 2, '20180113', '20180514', N'Городская больница №2', N'Окноч. диагноз 1', 0),
			(1, 2, '20191030', '20200229', N'Городская больница №2', N'Окноч. диагноз 2', 0);
		GO

		SET IDENTITY_INSERT [dbo].[Hospitalizations] OFF;
		GO