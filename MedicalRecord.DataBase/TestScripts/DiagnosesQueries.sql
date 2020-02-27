-- Тестовые запросы к таблице Диагнозы
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.Diagnoses;
--GO

--SELECT
--	[Id],
--	[Name],
--	[Description],
--	[IsDeleted]
--FROM dbo.Diagnoses;

--процедура GetAll
EXEC dbo.spDiagnoses_GetAll;
GO

--процедура GetAllWithOrder
--EXEC dbo.spDiagnoses_GetAllWithOrder 'Name';
--GO

--процедура GetLike
--EXEC dbo.spDiagnoses_GetLike N'Диа';
--GO

--процедура GetById
--EXEC dbo.spDiagnoses_GetById 2;
--GO

--процедура Update
--EXEC dbo.spDiagnoses_Update 1, N'Новый', N'Новое описание';
--EXEC dbo.spDiagnoses_GetAll;
--GO

--процедура Remove
--EXEC dbo.spDiagnoses_Remove 1;
--EXEC dbo.spDiagnoses_GetAll;
--GO

--процедура Add
--EXEC dbo.spDiagnoses_Add N'Новый', N'Новое описание';
--EXEC dbo.spDiagnoses_GetAll;
--GO
