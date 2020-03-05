-- Тестовые запросы к таблице Группа здаровья
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.HealthGroups;
--GO

--SELECT
--	[Id],
--	[Title],
--	[Description],
--	[IsDeleted]
--FROM dbo.HealthGroups;

--процедура GetAll
EXEC dbo.spHealthGroups_GetAll;
GO

--процедура GetAllWithOrder
--EXEC dbo.spHealthGroups_GetAllWithOrder 'Title';
--GO

--процедура GetLike
--EXEC dbo.spHealthGroups_GetLike N'Гру';
--GO

--процедура GetById
--EXEC dbo.spHealthGroups_GetById 2;
--GO

--процедура Update
--EXEC dbo.spHealthGroups_Update 1, N'Новый', N'Новое описание';
--EXEC dbo.spHealthGroups_GetAll;
--GO

--процедура Remove
--EXEC dbo.spHealthGroups_Remove 1;
--EXEC dbo.spHealthGroups_GetAll;
--GO

--процедура Add
--EXEC dbo.spHealthGroups_Add N'Новый', N'Новое описание';
--EXEC dbo.spHealthGroups_GetAll;
--GO