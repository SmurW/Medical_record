-- Тестовые запросы к таблице Доктора
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.Doctors;
--GO

--SELECT
--	  [Id]
--	, [LastName]
--	, [FirstName]
--	, [MiddleName]
--	, [SpecializationId]
--	, [IsDeleted]
--FROM dbo.Doctors;

--SELECT [d].[Id]
--	, [d].[LastName]
--	, [d].[FirstName]
--	, [d].[MiddleName]
--	, [d].[SpecializationId]
--	, [s].[Name] AS 'Specialization'
--FROM dbo.Doctors AS d
--INNER JOIN dbo.Specializations AS s
--	ON d.SpecializationId = s.Id
--WHERE d.IsDeleted = 0
--ORDER BY d.Id;


--процедура GetAll
EXEC dbo.spDoctors_GetAll;
GO

--процедура GetById
--EXEC dbo.spDoctors_GetById 1;
--GO

--процедура Add
--EXEC dbo.spDoctors_Add N'Иванов', N'Иван', N'Иванович', 4;
--GO