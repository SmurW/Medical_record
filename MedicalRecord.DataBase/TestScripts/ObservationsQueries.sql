-- Тестовые запросы к таблице Наблюдений
USE [MedicalRecord]
GO

SELECT [Id]
     , [PatientId]
     , [DiagnosisId]
     , [DoctorId]
     , [StartObservationDate]
     , [EndObservationDate]
FROM dbo.Observations;

SELECT [Id]
     , [PatientId]
     , [DiagnosisId]
     , [DoctorId]
     , [StartObservationDate]
     , [EndObservationDate]
FROM dbo.Observations
WHERE PatientId = 1;