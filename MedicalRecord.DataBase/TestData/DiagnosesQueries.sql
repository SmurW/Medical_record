USE [MedicalRecord]
GO

--SELECT
--	[Id],
--	[Name],
--	[Description],
--	[IsDeleted]
--FROM dbo.Diagnoses;

--процедура GetAll
EXEC dbo.spDiagnoses_GetAll;
GO