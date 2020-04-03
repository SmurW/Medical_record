-- Тестовые запросы к таблице Госпитализация
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.Hospitalizations;
--GO

SELECT
	  [Id]
	, [PatientId]
	, [StartHospitalizationDate]
	, [EndHospitalizationDate]
	, [MedicalOrganization]
	, [DefinitiveDiagnosis]
	, [IsDeleted]
FROM dbo.Hospitalizations;


--процедура GetCountByPatientId
--EXEC dbo.spHospitalizations_GetCountByPatientId 1;
--GO

--процедура GetByPatientId
--EXEC dbo.spHospitalizations_GetByPatientId 1;
--GO

--процедура Add
--EXEC dbo.spHospitalizations_Add 1, '20180202', '20180712', N'Городская больница №2', N'Нез. диагноз 3';
--GO