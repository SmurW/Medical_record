-- Тестовые запросы к таблице Госпитализация
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.Hospitalizations;
--GO

--SELECT
--	  [Id]
--	, [PatientId]
--	, [StartHospitalizationDate]
--	, [EndHospitalizationDate]
--	, [MedicalOrganization]
--	, [DefinitiveDiagnosis]
--	, [IsDeleted]
--FROM dbo.Hospitalizations;


--процедура GetCountById
EXEC dbo.sp_Hospitalizations_GetCountById 1;
GO

--процедура GetById
--EXEC dbo.spHospitalizations_GetById 2;
--GO

--процедура Add
--EXEC dbo.spHospitalizations_Add '20180202', '20180712', N'Городская больница №2', N'Нез. диагноз 3';
--GO