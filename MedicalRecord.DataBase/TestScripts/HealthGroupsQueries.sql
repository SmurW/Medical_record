-- Тестовые запросы к таблице Группы здаровья
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.HealtGroups;
--GO

--SELECT
--	[Id],
--	[Title]
--	[IsDeleted]
--FROM dbo.HealthGroups;

--процедура GetAll
EXEC dbo.spHealthGroups_GetAll;
GO

--процедура GetById
--EXEC dbo.spHealthGroups_GetById 2;
--GO
