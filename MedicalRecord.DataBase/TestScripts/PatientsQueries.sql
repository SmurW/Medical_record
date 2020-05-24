-- Тестовые запросы к таблице Пациенты
USE [MedicalRecord]
GO

--очистка таблицы
--TRUNCATE TABLE dbo.Patients;
--GO

--SELECT
--	*
--FROM dbo.Patients;

--процедура GetAll
EXEC spPatients_GetAll;
GO

--процедура GetPatientId
--EXEC dbo.spPatients_GetPaitentId

--процедура GetByCardNumber
--EXEC dbo.spPatients_GetByCardNumber
--GO

--процедура GetByLastName
--EXEC dbo.spPatients_GetByLastName
--GO

--процедура Update
--EXEC dbo.spPatients_Update 1, N'Обновленный', N'Обновленный пациент', N'Обновленный пациент', N'Обновленный пациент',
--	    N'Обновленный', '19840323', '20050513', N'Обновленный', N'Обновленный', N'Обновленный', N'Обновленный', '19951111', N'Обновленный';

--EXEC dbo.spPatients_GetAll;
--GO

--процедура Remove
--EXEC dbo.spPatients_Remove 1;
--EXEC dbo.spPatients_GetAll;
--GO

--процедура Add
--EXEC dbo.spPatients_Add N'Новый', N'Новый пациент', N'Новый пациент', N'Новый пациент',
--	    N'Новый', '19840323', '20050513', N'Новый', N'Новый', N'Новый', N'Новый', '19951111', N'Новый';
--EXEC dbo.spMedications_GetAll;
--GO