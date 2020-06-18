-- Тестовые запросы к таблице Процедуры
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.Procedures;
--GO

--SELECT
--	[Id],
--	[Name],
--	[Description],
--	[IsDeleted]
--from dbo.Procedures;

--процедура GetAll
EXEC dbo.spProcedures_GetAll;
GO

--процедура GetAllWithOrder
--EXEC dbo.spProcedures_GetAllWithOrder 'Name';
--GO

--процедура GetLike
--EXEC dbo.spProcedures_GetLike N'Про';
--GO

--процедура GetById
--EXEC dbo.spProcedures_GetById 2;
--GO

--процедура Update
--EXEC dbo.spProcedures_Update 1, N'Новый', N'Новое описание';
--EXEC dbo.spProcedures_GetAll;
--GO

--процедура Remove
--EXEC dbo.spProcedures_Remove 1;
--EXEC dbo.spProcedures_GetAll;
--GO

--процедура Add
--EXEC dbo.spProcedures_Add N'Новый', N'Новое описание';
--EXEC dbo.spProcedures_GetAll;
--GO