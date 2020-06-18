-- Тестовые запросы к таблице Лекарства
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.Medications;
--GO

--SELECT
--	*
--from dbo.Medications;

--процедура GetAll
EXEC spMedications_GetAll;
GO

--процедура GetAllWithOrder
--EXEC dbo.spMedications_GetAllWithOrder 'Name';
--GO

--процедура GetLike
--EXEC dbo.spMedications_GetLike N'Глю';
--GO

--процедура Update
--EXEC dbo.spMedications_Update 1, N'Обновленный', N'Обновленное лекарство.',
--	    10, 11, 12, 13, '19930320', '19951001';
--EXEC dbo.spMedications_GetAll;
--GO

--процедура Remove
--EXEC dbo.spMedications_Remove 1;
--EXEC dbo.spMedications_GetAll;
--GO

--процедура Add
--EXEC dbo.spMedications_Add N'Новый', N'Новое описание',
--		10, 11, 12, 13, '19930320', '19951001';
--EXEC dbo.spMedications_GetAll;
--GO