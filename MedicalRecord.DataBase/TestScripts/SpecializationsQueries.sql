-- Тестовые запросы к таблице Специализация
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.Specializations;
--GO

--SELECT
--	[Id],
--	[Name]
--	[IsDeleted]
--FROM dbo.Specializations;

--процедура GetAll
EXEC dbo.spSpecializations_GetAll;
GO

--процедура GetAllWithOrder
--EXEC dbo.spSpecializations_GetAllWithOrder 'Name';
--GO

--процедура GetLike
--EXEC dbo.spSpecializations_GetLike N'ЛОР';
--GO

--процедура GetById
--EXEC dbo.spSpecializations_GetById 2;
--GO

--процедура Update
--EXEC dbo.spSpecializations_Update 1, N'Новый';
--EXEC dbo.spSpecializations_GetAll;
--GO

--процедура Remove
--EXEC dbo.spSpecializations_Remove 1;
--EXEC dbo.spSpecializations_GetAll;
--GO

--процедура Add
--EXEC dbo.spSpecializations_Add N'Новый';
--EXEC dbo.spSpecializations_GetAll;
--GO